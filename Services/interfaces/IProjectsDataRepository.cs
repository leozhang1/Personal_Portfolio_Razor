namespace Personal_Portfolio_Razor.Services;


public interface IProjectsDataRepository<T>
{
    Dictionary<string, IEnumerable<T>> GetData();
    IEnumerable<T> Search(string searchTerm);
}
