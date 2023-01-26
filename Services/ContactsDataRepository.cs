
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Services;

public class ContactsDataRepository : IContactsDataRepository<ContactMeModel>
{
    private List<ContactMeModel>? contacts;

    public ContactsDataRepository()
    {
        contacts = new List<ContactMeModel>();
    }

    public IEnumerable<ContactMeModel> GetData()
    {
        return contacts!;
    }

    public void PostData(ContactMeModel model)
    {
        contacts?.Add(model);
    }
}

