namespace Personal_Portfolio_Razor.Models;


public class BlogModel
{
    public string title;
    public DateTime date;
    public string previewDesc;
    public string routeName;

    public BlogModel(string title, DateTime date, string previewDesc, string routeName)
    {
        this.title = title;
        this.date = date;
        this.previewDesc = previewDesc;
        this.routeName = routeName;
    }

    public override string ToString()
    {
        return $"title: {title}, date: {date}, previewDesc: {previewDesc}, routeName: {routeName},";
    }
}
