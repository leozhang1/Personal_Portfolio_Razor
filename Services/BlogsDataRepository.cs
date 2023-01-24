
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Services;

public class BlogsDataRepository : IBlogsDataRepository<BlogModel>
{
    private List<BlogModel> blogs;

    public BlogsDataRepository()
    {
        blogs = new List<BlogModel>()
        {
            new BlogModel("My New Site", new DateTime(2022, 4, 22), "Hello there! Welcome to my website!","welcomeBlog"),

            new BlogModel("Independence Day Fireworks By the Lake", new DateTime(2022, 7, 4), "Fireworks look even better by the lake!","fireworksBlog"),

            new BlogModel("My Linux-distro Hopping Journey And My Choice of Linux Distro", new DateTime(2022, 6, 25), "Distro hopping was a time-consuming but rewarding experience!","linuxDistroTalk"),

            new BlogModel("Last Semester of Grad School", new DateTime(2022, 8, 26), "My final semester of graduate school has begun!","finalSemester"),
        };
    }

    public IEnumerable<BlogModel> Sort(bool isNewest)
    {
        blogs.Sort((x, y) => isNewest ? y.date.CompareTo(x.date) : x.date.CompareTo(y.date));
        return blogs;
    }
}

