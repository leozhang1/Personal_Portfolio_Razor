using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Personal_Portfolio_Razor.Pages
{
    public class BlogDetailsModel : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public string routeName {get; set;} = null!;

        public void OnGet(string routeName = null!)
        {
            this.routeName = routeName;
        }
    }
}
