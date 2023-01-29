
using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.ViewComponents;

public class BlogDetailsViewComponent : ViewComponent
{
    private readonly IBlogsDataRepository<BlogModel> dataRepository;
    public IEnumerable<BlogModel> blogs;
    public BlogModel? blog { get; set; }

    public BlogDetailsViewComponent(IBlogsDataRepository<BlogModel> dataRepository)
    {
        this.dataRepository = dataRepository;
        blogs = dataRepository.GetData();
    }

    public IViewComponentResult Invoke(string routeName = "")
    {
        blog = blogs.FirstOrDefault(b => b.routeName == routeName);

        return View(blog);
    }
}
