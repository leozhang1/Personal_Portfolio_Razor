using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages
{
    public class BlogDetailsModel : PageModel
    {
        private readonly IBlogsDataRepository<BlogModel> dataRepository;
        public IEnumerable<BlogModel> blogs;
        public BlogModel? blog { get; set; }

        public BlogDetailsModel(IBlogsDataRepository<BlogModel> dataRepository)
        {
            this.dataRepository = dataRepository;
            blogs = dataRepository.GetData();
        }

        public IActionResult OnGet(string routeName)
        {
            blog = blogs.SingleOrDefault(b => b.routeName == routeName);

            if (blog is null)
            {
                return RedirectToPage("/Errors/BlogNotFound");
            }

            return Page();
        }
    }
}
