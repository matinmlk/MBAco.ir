
namespace MBAco.BLL
{
    public interface IBusinessBase<TItem>
    {
        TItem GetItem(long id);
        TItem SaveItem(TItem dataItem);
        void DeleteItem(long id);
        void DeleteItem(TItem dataItem);
    }
}
