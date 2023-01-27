
using Microsoft.EntityFrameworkCore;
using Personal_Portfolio_Razor.Models;

namespace Personal_Portfolio_Razor.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // increment the id of the model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }

    public DbSet<ContactMeModel> ContactDb { get; set; }

}
