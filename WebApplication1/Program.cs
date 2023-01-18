using AssociationCRMDawanPoe.Persistance;
using AssociationCRMDawanPoe.Service;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProjectAPI.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".DawanProject.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(300);
    options.Cookie.IsEssential = true;
});


string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



builder.Services.Add(new ServiceDescriptor(typeof(IMenuRepository), new MenuRepository(connectionString)));
    //<IMenuRepository, IMenuRepository>();

builder.Services.AddScoped<IMenuService, MenuServiceImpl>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Menu}/{action=Menu}/{id?}");

app.Run();
