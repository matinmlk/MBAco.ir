
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace MBAco.DAL
{
    [System.ComponentModel.DataObject]
    public class BaseStaticEntity<TEntity, TDataContext>
        where TDataContext : DataContext, new()
        where TEntity : class
    {
        #region Members & Fields
        protected static readonly IBaseEntity<TEntity, TDataContext> repository = new BaseEntity<TEntity, TDataContext>();
        #endregion

        #region Generic Object Data Source
        public static TDataContext DataContext
        {
            get
            {
                return repository.DataContext;
            }
        }

        public static string PrimaryKeyName
        {
            get
            {
                return repository.PrimaryKeyName;
            }
        }

        protected static PropertyInfo PrimaryKey
        {
            get
            {
                return repository.PrimaryKey;
            }
        }

        protected static object GetPrimaryKeyValue(TEntity entity)
        {
            return PrimaryKey.GetValue(entity, null);
        }

        #endregion

        #region Generic CRUD methods
        //---------------------Selects----------------------------------

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll()
        {
            ////Logger.Logging("Start of ", "SelectAll", "DAL-BaseStaticEntity", typeof(TEntity).Name);
            return repository.SelectAll();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(string sortExpression)
        {
            ////Logger.Logging("Start of ", "SelectAll ", "DAL-BaseStaticEntity", typeof(TEntity).Name);
            return repository.SelectAll(sortExpression);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(string sortExpression, int maximumRows, int startRowIndex)
        {
            ////Logger.Logging("Start of ", "SelectAll ", "DAL-BaseStaticEntity", typeof(TEntity).Name);
            if (maximumRows == -1)
                return repository.SelectAll(sortExpression);
            else
                return repository.SelectAll(sortExpression, maximumRows, startRowIndex);
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static IQueryable<TEntity> SelectAll(int maximumRows, int startRowIndex)
        {
            if (maximumRows == -1)
                return repository.SelectAll();
            else
                return repository.SelectAll(maximumRows, startRowIndex);
        }

        public static int Count()
        {
            return repository.Count();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static List<TEntity> SelectAllAsList()
        {
            return SelectAll().ToList();
        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public static TEntity GetEntity(object id)
        {
            return repository.GetEntity(id);
        }

        //----------------------Insert------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)]
        public static TEntity Insert(TEntity entity)
        {
            try
            {
                return repository.Insert(entity);
            }
            catch (Exception e)
            {
                throw new Exception("Error: DAL Insert Exception, "+ e.Message);
            }
        }

        public static TEntity Insert(TEntity entity, bool submitChanges)
        {
            return repository.Insert(entity, submitChanges);
        }

        //-----------------------Update-----------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public static void Update(TEntity entity)
        {
            repository.Update(entity);
        }

        public static void Update(TEntity entity, bool submitChanges)
        {
            repository.Update(entity, submitChanges);
        }

        //----------------------Delete-------------------------------------------
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)]
        public static void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }

        public static void Delete(TEntity entity, bool submitChanges)
        {
            repository.Delete(entity, submitChanges);
        }
        //----------------------Save-------------------------------------------
        public static void Save(TEntity entity)
        {
            ////Logger.Logging("Start of ", "Save ", "DAL-BaseStaticEntity", typeof(TEntity).Name);
            var pkValue = GetPrimaryKeyValue(entity);
            Type entityType = typeof(TEntity);
            ParameterExpression param = Expression.Parameter(entityType, "e");
            MemberExpression property = Expression.Property(param, repository.PrimaryKeyName);
            ConstantExpression value = Expression.Constant(GetPrimaryKeyValue(entity), typeof(long));
            Expression<Func<TEntity, bool>> predicate = Expression.Lambda<Func<TEntity, bool>>(Expression.Equal(property, value), param);

            Table<TEntity> tblOriginal = DataContext.GetTable<TEntity>();
            var tmp = tblOriginal.Where(predicate).SingleOrDefault();
            if (tmp == null)
            {
                Insert(entity);
            }
            else
            {
                Update(entity);
            }
            ////Logger.Logging("End of ", "Save ", "DAL-BaseStaticEntity", typeof(TEntity).Name);
        }
        #endregion
    }
}
