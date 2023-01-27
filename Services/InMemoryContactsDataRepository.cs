
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Services;

public class InMemoryContactsDataRepository : IContactsDataRepository<ContactMeModel>
{
    private List<ContactMeModel>? contacts;

    public InMemoryContactsDataRepository()
    {
        contacts = new List<ContactMeModel>();
    }

    public int Commit()
    {
        return 0;
    }

    public ContactMeModel? Delete(int id)
    {
        var model = GetById(id);
        if (model is null)
        {
            System.Console.WriteLine("model not found");
            return null;
        }

        contacts!.Remove(model);
        return model;
    }

    public ContactMeModel? GetById(int id)
    {
        return contacts!.Find(model => model.Id == id);
    }

    public IEnumerable<ContactMeModel> GetData(string name)
    {
        return from contact in contacts where contact.name == name select contact;
    }

    public IEnumerable<ContactMeModel> GetData()
    {
        return from contact in contacts select contact;
    }

    public ContactMeModel PostData(ContactMeModel model)
    {
        contacts?.Add(model);
        return model;
    }

    public ContactMeModel? Update(ContactMeModel model)
    {
        var contact = GetById(model.Id);
        if (contact is null)
        {
            System.Console.WriteLine("model not found");
            return null;
        }

        contacts![model.Id].name = model.name;
        contacts![model.Id].email = model.email;
        contacts![model.Id].subject = model.subject;
        contacts![model.Id].message = model.message;

        return model;
    }
}

