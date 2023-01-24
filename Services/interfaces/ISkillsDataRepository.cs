namespace Personal_Portfolio_Razor.Services;

public interface ISkillsDataRepository<T>
{
    Dictionary<string, IEnumerable<T>> GetData();
}
