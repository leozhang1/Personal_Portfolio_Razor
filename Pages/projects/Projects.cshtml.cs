using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages
{
    public class ProjectsModel : PageModel
    {
        private readonly IProjectsDataRepository<ProjectCardModel> dataRepository;
        public IEnumerable<ProjectCardModel> projects;

        [BindProperty(SupportsGet=true)]
        public string searchTerm { get; set; }

        public ProjectsModel(IProjectsDataRepository<ProjectCardModel> dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        public void OnGet()
        {
            projects = dataRepository.Search(searchTerm);
        }
    }
}
