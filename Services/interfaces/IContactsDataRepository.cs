using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Services;

public interface IContactsDataRepository<T>
{
    T? PostData(T model);
    T? Update(T model);
    IEnumerable<T> GetData(string name);
    IEnumerable<T> GetData();
    T? Delete(int id);
    T? GetById(int id);
    int Commit();
}