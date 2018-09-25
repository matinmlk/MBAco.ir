
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

namespace MBAco.BLL
{
    [Serializable()]
    public abstract class BusinessListBase<T> : ISearchable
        where T : class
    {
        #region Members & Properties
        protected string m_CultureID = "en-US";
        protected bool m_IsReadOnly = false;       //flag for setting collection to read-only mode

        /// <summary>
        /// Number of elements in the collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        /// <summary>
        /// Flag sets whether or not this collection is read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return m_IsReadOnly;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of the object.
        /// </summary>
        protected BusinessListBase()
        {
            Initialize(false);
        }

        protected BusinessListBase(string cultureID)
        {
            Initialize(false);
            m_CultureID = cultureID;
        }

        public BusinessListBase(Boolean readOnly)
        {
            Initialize(readOnly);
        }

        public BusinessListBase(string cultureID, Boolean readOnly)
        {
            Initialize(readOnly);
            m_CultureID = cultureID;
        }
        #endregion

        #region Initialize

        /// <summary>
        /// Override this method to set up event handlers so user
        /// code in a partial class can respond to events raised by
        /// generated code.
        /// </summary>
        protected virtual void Initialize(Boolean readOnly)
        {
            /* allows subclass to initialize events before any other activity occurs */
            m_IsReadOnly = readOnly;
        }

        #endregion

        #region Methods

        public virtual void Insert(T businessObject)
        {
            //if (IsReadOnly) throw new Exception("The List is Readonly");
            throw new System.NotImplementedException();
        }

        public virtual void Delete(T businessObject)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(T businessObject)
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T businessObject)
        {
            throw new System.NotImplementedException();
        }

        public long CountLocalizes(string cultureID)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetAll(long userId)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetAll(string sortExpression)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetAll(string sortExpression, int maximumRows, int startRowIndex)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual List<T> GetAll(string searchString, bool searchPartial, int maximumRows, int startRowIndex)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetAll(int maximumRows, int startRowIndex)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<T> GetByForeignKey(long Id)
        {
            throw new System.NotImplementedException();
        }

        #endregion //End of methods

        #region ISearchable Members
        public IQueryable<object> Search(LambdaExpression predicate)
        {
            return Search(predicate, "en-US", - 1);
        }

        public IQueryable<object> Search(LambdaExpression predicate, long userId)
        {
            return Search(predicate, "en-US", userId);
        }

        public IQueryable<object> Search(LambdaExpression predicate, string cultureID, long userId)
        {
            if (predicate == null) throw new ArgumentNullException("Error: Predicate missing!");
            Collection<T> innerCollection = new Collection<T>();
            IQueryable<T> source;
            if (userId == -1)
            {
                IQueryable<T> list = this.GetAll().AsQueryable<T>();
                foreach (var item in list)
                {
                    innerCollection.Add(item);
                }
                source = innerCollection.AsQueryable<T>();
            }
            else
            {
                IQueryable<T> list = this.GetAll(userId).AsQueryable<T>();
                foreach (var item in list)
                {
                    innerCollection.Add(item);
                }
                source = innerCollection.AsQueryable<T>();
            }
            var query = source.Provider.CreateQuery(
                    Expression.Call(
                    typeof(Queryable), "Where",
                    new Type[] { source.ElementType },
                    source.Expression, Expression.Quote(predicate))
                );
            return query.Cast<object>();
        }

        public IQueryable<object> Search(string predicate)
        {
            ////TODO: It should complete later
            //if (string.IsNullOrWhiteSpace(predicate)) return GetAll();
            ////LambdaExpression lambda = System.Linq.Dynamic.DynamicExpression.ParseLambda(typeof(T), typeof(bool), predicate, null);
            //return GetAll(true);
            throw new System.NotImplementedException();
        }
        #endregion //End ISearchable Members
    }
}
