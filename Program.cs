using Microsoft.EntityFrameworkCore;
using Personal_Portfolio_Razor.Data;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;
// dotnet tool install --global dotnet-ef

// creating a new razor page with a page model via the command line
// dotnet new page --name Model --namespace Personal_Portfolio_Razor.Pages --output Pages/Model

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ISkillsDataRepository<string>, SkillsDataRepository>();
builder.Services.AddSingleton<IProjectsDataRepository<ProjectCardModel>, ProjectsDataRepository>();
builder.Services.AddSingleton<IBlogsDataRepository<BlogModel>, BlogsDataRepository>();
builder.Services.AddSingleton<IContactsDataRepository<ContactMeModel>, ContactsDataRepository>();


builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("sqlServerString")
    )
);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
