
using System.Linq;
using System.Linq.Expressions;

namespace MBAco.BLL
{
    public interface ISearchable
    {
        IQueryable<object> Search(string predicate);
        IQueryable<object> Search(LambdaExpression predicate);
        IQueryable<object> Search(LambdaExpression predicate, long userId);
        IQueryable<object> Search(LambdaExpression predicate, string cultureID, long userId);
    }
}
