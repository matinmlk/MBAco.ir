
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace MBAco.DAL
{
    public interface IBaseEntity<TEntity, TDataContext> where TEntity : class
    {
        TDataContext DataContext { get; }
        DataLoadOptions LoadOptions { get; set; }
        string PrimaryKeyName { get; }
        PropertyInfo PrimaryKey { get; }
        void SubmitChanges();
        int Count();

        //Selects - the overrides are to support ObjectDataSource functionality
        IQueryable<TEntity> SelectAll();
        IQueryable<TEntity> SelectAll(string sortExpression); //This is in the format '[ColumnName]' or '[ColumnName] DESC'
        IQueryable<TEntity> SelectAll(int maximumRows, int startRowIndex);
        IQueryable<TEntity> SelectAll(string sortExpression, int maximumRows, int startRowIndex);
        List<TEntity> SelectAllAsList();

        //CRUD
        TEntity GetEntity(object id);
        TEntity Insert(TEntity entity);
        TEntity Insert(TEntity entity, bool submitChanges);
        void Update(TEntity entity);
        void Update(TEntity entity, bool submitChanges);
        void Delete(TEntity entity);
        void Delete(TEntity entity, bool submitChanges);
    }
}
