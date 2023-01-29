using Microsoft.EntityFrameworkCore;
using Personal_Portfolio_Razor.Data;
using Personal_Portfolio_Razor.Models;
using Personal_Portfolio_Razor.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ISkillsDataRepository<string>, SkillsDataRepository>();
builder.Services.AddSingleton<IProjectsDataRepository<ProjectCardModel>, ProjectsDataRepository>();
builder.Services.AddSingleton<IBlogsDataRepository<BlogModel>, BlogsDataRepository>();

// same instance for a single http request, but a new one for a different http request
builder.Services.AddScoped<IContactsDataRepository<ContactMeModel>, SqlContactsDataRepository>();

builder.Services.AddDbContextPool<ApplicationDbContext>(
    options => {
        // options.UseSqlServer(
        //         builder.Configuration.GetConnectionString("localDB")
        //     );

        // ElephantSQL formatting
        var uriString = builder.Configuration.GetConnectionString("postgresDB")!;
        var uri = new Uri(uriString);
        var db = uri.AbsolutePath.Trim('/');
        var user = uri.UserInfo.Split(':')[0];
        var passwd = uri.UserInfo.Split(':')[1];
        var port = uri.Port > 0 ? uri.Port : 5432;
        var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
            uri.Host, db, user, passwd, port);

        options.UseNpgsql(
                connStr
        );

    }
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
