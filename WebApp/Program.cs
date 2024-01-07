using Microsoft.Extensions.DependencyInjection;
using Plugins.DataStore.InMemory;
using System.Net.Mime;
using System.Text;
using UseCases.CategoriesUseCases;
using UseCases.DataStorePluginInterfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICategoryRepository, CategoriesInMemoryRepository>();
builder.Services.AddTransient<IViewCategoriesUseCase, ViewCategoriesUseCase>();
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

