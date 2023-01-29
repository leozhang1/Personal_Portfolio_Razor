using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;

namespace Personal_Portfolio_Razor.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactMeModel? contactMeModel { get; set; }

    [TempData]
    public string postedMessage { get; set; }

    private readonly IContactsDataRepository<ContactMeModel> dataRepository;
    private readonly ILogger<ContactModel> logger;

    public ContactModel(IContactsDataRepository<ContactMeModel> dataRepository, ILogger<ContactModel> logger)
    {
        this.dataRepository = dataRepository;
        this.logger = logger;
    }

    public void logContacts()
    {
        // System.Console.WriteLine("Logging contacts");
        foreach (var contact in dataRepository.GetData())
        {
            // System.Console.WriteLine(contact);
            logger.LogInformation($"{contact}");
        }
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            // return RedirectToPage("/Errors/ContactPostError");
            // return RedirectToPage("/contact/Contact");
            return Page();
        }

        dataRepository.PostData(contactMeModel!);
        TempData["postedMessage"] = "Thank you, your message has been sent!";

        await Task.Delay(1);
        logContacts();

        return RedirectToPage("/contact/Contact");
    }
}
