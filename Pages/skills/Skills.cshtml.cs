using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages
{
    public class SkillsModel : PageModel
    {
        private readonly ISkillsDataRepository<string> dataRepository;
        public IEnumerable<string> programmingLanguages { get; set; }
        public IEnumerable<string> techs { get; set; }
        public IEnumerable<string> pythonLibraries { get; set; }
        public IEnumerable<string> linuxTools { get; set; }


        public SkillsModel(ISkillsDataRepository<string> dataRepository)
        {
            this.dataRepository = dataRepository;
        }

        public void OnGet()
        {
            programmingLanguages = dataRepository.GetData()["programmingLanguages"];
            techs = dataRepository.GetData()["techs"];
            pythonLibraries = dataRepository.GetData()["pythonLibraries"];
            linuxTools = dataRepository.GetData()["linuxTools"];

        }
    }
}
