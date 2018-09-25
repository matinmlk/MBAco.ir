
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Web;

namespace MBAco.DAL
{
    [System.ComponentModel.DataObject]
    public class BaseEntity<TEntity, TDataContext> : IBaseEntity<TEntity, TDataContext>
        where TDataContext : DataContext, new()
        where TEntity : class
    {
        #region Properties
        private string _dataContextKey;
        protected string DataContextKey
        {
            get
            {
                if (_dataContextKey == null)
                {
                    // Include the type name of the context.
                    // Results in "dataContext_MyNamespace.TableDataContext" for GenericRepository<MyTableObject, MyNamespace.TableDataContext>.SelectAll()
                    _dataContextKey = "dataContext_" + typeof(TDataContext).FullName;
                }
                return _dataContextKey;
            }
        }

        public TDataContext DataContext
        {
            get
            {
                //We are in a web app, use a request scope
                if (HttpContext.Current != null)
                {
                    TDataContext dataContext = (TDataContext)HttpContext.Current.Items[DataContextKey];
                    if (dataContext == null)
                    {
                        dataContext = CreateDataContext();
                        HttpContext.Current.Items.Add(DataContextKey, dataContext);
                    }
                    return dataContext;
                }
                else
                {
                    // Creates a Thread Scoped DataContext object that can be reused. 
                    // The DataContext is stored in Thread local storage.
                    // See here http://code.msdn.microsoft.com/multitierlinqtosql/Thread/View.aspx?ThreadId=361
                    //for a discussion of this code.

                    LocalDataStoreSlot threadData = Thread.GetNamedDataSlot(DataContextKey);
                    object dataContext = null;

                    if (threadData != null)
                        dataContext = Thread.GetData(threadData);

                    if (dataContext == null)
                    {
                        dataContext = CreateDataContext();
                        if (threadData == null)
                            threadData = Thread.AllocateNamedDataSlot(DataContextKey);

                        Thread.SetData(threadData, dataContext);
                    }
                    return (TDataContext)dataContext;
                }
            }
        }

        protected TDataContext CreateDataContext()
        {
            TDataContext dataContext = new TDataContext();
            return dataContext;
        }


        #region Methods
        public DataContext GetDataContext()
        {
            return DataContext;
        }
        #endregion

        /// <summary>
        /// Removes the current DataContext from the Request/Thread and calls dispose on it
        /// </summary>
        protected void DiscardDataContext()
        {
            if (HttpContext.Current != null)
            {
                TDataContext dataContext = (TDataContext)HttpContext.Current.Items[DataContextKey];
                if (dataContext != null)
                {
                    HttpContext.Current.Items.Remove(DataContextKey);
                    dataContext.Dispose();
                }
            }
            else
            {
                LocalDataStoreSlot threadData = Thread.GetNamedDataSlot(DataContextKey);
                TDataContext dataContext = null;

                if (threadData != null)
                    dataContext = (TDataContext)Thread.GetData(threadData);

                if (dataContext != null)
                {
                    Thread.FreeNamedDataSlot(DataContextKey);
                    dataContext.Dispose();
                }
            }
        }

        public void SubmitChanges()
        {
            DataContext.SubmitChanges();
        }

        public DataLoadOptions LoadOptions
        {
            get
            {
                return DataContext.LoadOptions;
            }
            set
            {
                DataContext.LoadOptions = value;
            }
        }

        #endregion

        #region Helper methods

        private MetaDataMember _metaPrimaryKey;
        private MetaDataMember MetaPrimaryKey
        {
            get
            {
                if (_metaPrimaryKey == null)
                {
                    Type entityType = typeof(TEntity);
                    MetaTable mapping = DataContext.Mapping.GetTable(entityType);

                    int count = mapping.RowType.DataMembers.Count(d => d.IsPrimaryKey);
                    if (count < 1) throw new Exception(String.Format("Table {0} does not contain a Primary Key field", mapping.TableName));
                    if (count > 1) throw new Exception(String.Format("Table {0} contains a composite primary key field", mapping.TableName));

                    _metaPrimaryKey = mapping.RowType.DataMembers.Single(d => d.IsPrimaryKey);
                }
                return _metaPrimaryKey;
            }
        }

        private PropertyInfo _primaryKey;
        public PropertyInfo PrimaryKey
        {
            get
            {
                if (_primaryKey == null)
                {
                    _primaryKey = typeof(TEntity).GetProperty(PrimaryKeyName);
                }
                return _primaryKey;
            }
        }

        private string _primaryKeyName;
        public string PrimaryKeyName
        {
            get
            {
                if (string.IsNullOrEmpty(_primaryKeyName))
                {
                    _primaryKeyName = MetaPrimaryKey.Name;
                }

                return _primaryKeyName;
            }
        }

        protected object GetPrimaryKeyValue(TEntity entity)
        {
            return PrimaryKey.GetValue(entity, null);
        }

        protected TEntity GetEntity(TEntity entity)
        {
            return GetEntity(GetPrimaryKeyValue(entity));
        }

        private List<PropertyInfo> _databaseProperties;
        protected List<PropertyInfo> DatabaseProperties
        {
            get
            {
                if (_databaseProperties == null)
                {
                    Type entityType = typeof(TEntity);
                    MetaTable mapping = DataContext.Mapping.GetTable(typeof(TEntity));
                    _databaseProperties = mapping.RowType.DataMembers
                        .Where(x => x.DbType != null)
                        .Select(x => entityType.GetProperty(x.Name))
                        .ToList();
                }
                return _databaseProperties;
            }
        }

        /// <summary>
        /// Update all properties of a linq object that are not associations with the values in another linq object.
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        protected void UpdateOriginalFromChanged(ref TEntity destination, TEntity source)
        {
            foreach (PropertyInfo pi in DatabaseProperties)
            {
                pi.SetValue(destination, pi.GetValue(source, null), null);
            }
        }

        #endregion

        #region Generic CRUD methods
        //---------------------Selects----------------------------------

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public TEntity GetEntity(object id)
        {
            MetaDataMember primaryKey = MetaPrimaryKey;

            Type entityType = typeof(TEntity);
            ParameterExpression param = Expression.Parameter(entityType, "e");
            MemberExpression property = Expression.Property(param, primaryKey.Name);
            ConstantExpression value = Expression.Constant(Convert.ChangeType(id, primaryKey.Type), primaryKey.Type);

            Expression<Func<TEntity, bool>> predicate = Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(property, value), param);

            return DataContext.GetTable<TEntity>().SingleOrDefault(predicate);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public IQueryable<TEntity> SelectAll()
        {
            ////Logger.Logging("Start of ", "SelectAll", "DAL-BaseEntity", typeof(TEntity).Name);
            return DataContext.GetTable<TEntity>();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public IQueryable<TEntity> SelectAll(string sortExpression)
        {
            if (string.IsNullOrEmpty(sortExpression))
            {
                return SelectAll();
            }
            return SelectAll().OrderBy(sortExpression);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public IQueryable<TEntity> SelectAll(string sortExpression, int maximumRows, int startRowIndex)
        {
            return SelectAll(sortExpression).Skip(startRowIndex).Take(maximumRows);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public IQueryable<TEntity> SelectAll(int maximumRows, int startRowIndex)
        {
            return SelectAll().Skip(startRowIndex).Take(maximumRows);
        }

        public int Count()
        {
            return SelectAll().Count();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<TEntity> SelectAllAsList()
        {
            return SelectAll().ToList();
        }

        //----------------------Insert------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public TEntity Insert(TEntity entity)
        {
            return Insert(entity, true);
        }

        public TEntity Insert(TEntity entity, bool submitChanges)
        {
         
            DataContext.GetTable<TEntity>().InsertOnSubmit(entity);
           
            if (submitChanges)
               
                    DataContext.SubmitChanges();
                
           
            return entity;
        }

        //-----------------------Update-----------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public void Update(TEntity entity)
        {
            Update(entity, true);
        }

        public void Update(TEntity entity, bool submitChanges)
        {
            TEntity original = GetEntity(entity);
            UpdateOriginalFromChanged(ref original, entity);

            if (submitChanges)
                DataContext.SubmitChanges();
        }

        //----------------------Delete-------------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public void Delete(TEntity entity)
        {
            Delete(entity, true);
        }

        public void Delete(TEntity entity, bool submitChanges)
        {
            TEntity delete = GetEntity(entity);
            DataContext.GetTable<TEntity>().DeleteOnSubmit(delete);

            if (submitChanges)
                DataContext.SubmitChanges();
        }

        #endregion

        public BaseEntity()
        {
            // TODO: Complete member initialization
        }
    }
}
