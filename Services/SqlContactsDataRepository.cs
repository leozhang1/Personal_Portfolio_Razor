
using Microsoft.EntityFrameworkCore;
using Personal_Portfolio_Razor.Data;
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Services;

public class SqlContactsDataRepository : IContactsDataRepository<ContactMeModel>
{
    private readonly ApplicationDbContext db;
    public SqlContactsDataRepository(ApplicationDbContext db)
    {
        this.db = db;
    }

    public int Commit()
    {
        return db.SaveChanges();
    }

    public ContactMeModel? Delete(int id)
    {
        var model = GetById(id);
        if (model is not null)
        {
            db.ContactDb.Remove(model);
        }

        Commit();

        return model;
    }

    public ContactMeModel? GetById(int id)
    {
        return db.ContactDb.Find(id);
    }

    public IEnumerable<ContactMeModel> GetData(string name)
    {
        var query = from m in db.ContactDb
                    where m.name!.StartsWith(name) || string.IsNullOrEmpty(name)
                    orderby m.name
                    select m;
        return query;
    }

    public IEnumerable<ContactMeModel> GetData()
    {
        var query = from m in db.ContactDb
                    select m;
        return query;
    }

    public ContactMeModel PostData(ContactMeModel model)
    {
        db.Add(model);
        Commit();
        return model;
    }

    public ContactMeModel Update(ContactMeModel model)
    {
        var entity = db.ContactDb.Attach(model);
        entity.State = EntityState.Modified;
        Commit();
        return model;
    }
}

