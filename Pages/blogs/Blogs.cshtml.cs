using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages
{
    public class BlogsModel : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public string blogSort { get; set; }

        private readonly IBlogsDataRepository<BlogModel> dataRepository;
        public IEnumerable<BlogModel> blogs;

        public BlogsModel(IBlogsDataRepository<BlogModel> dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public async Task OnGetAsync(string sortOrder)
        {
            blogSort = sortOrder == "Newest" ? "Oldest" : "Newest";

            switch (sortOrder)
            {
                case "Newest":
                    blogs = dataRepository.Sort(true);
                    break;
                default:
                    blogs = dataRepository.Sort(false);
                    break;
            }

            await Task.Delay(1);
        }
    }
}
