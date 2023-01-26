namespace Personal_Portfolio_Razor.Services;


public interface IContactsDataRepository<T>
{
    void PostData(T model);
    IEnumerable<T> GetData();
}