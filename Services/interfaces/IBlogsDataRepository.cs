namespace Personal_Portfolio_Razor.Services;


public interface IBlogsDataRepository<T>
{
    IEnumerable<T> Sort(bool isNewest);
}