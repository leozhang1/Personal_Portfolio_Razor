
using Microsoft.EntityFrameworkCore;
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<ContactMeModel> ContactDb { get; set; }


}
