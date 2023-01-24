using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;



namespace Personal_Portfolio_Razor.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactMeModel? contactMeModel {get; set;}

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/Index");
    }
}
