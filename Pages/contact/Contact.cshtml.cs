using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactMeModel? contactMeModel {get; set;}

    private readonly IContactsDataRepository<ContactMeModel> dataRepository;

    public ContactModel(IContactsDataRepository<ContactMeModel> dataRepository)
    {
        this.dataRepository = dataRepository;
    }

    public void logContacts()
    {
        // System.Console.WriteLine("Logging contacts");
        foreach (var contact in dataRepository.GetData())
        {
            System.Console.WriteLine(contact);
        }
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return RedirectToPage("/Errors/ContactPostError");
        }

        dataRepository.PostData(contactMeModel!);

        // logContacts();

        return RedirectToPage("/Index");
    }
}
