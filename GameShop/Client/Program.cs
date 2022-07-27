global using GameShop.Shared.Models;
global using GameShop.Shared.Dtos;
global using System.Net.Http.Json;
global using GameShop.Client.Services.ProductService;
global using GameShop.Client.Services.CategoryService;
using GameShop.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
await builder.Build().RunAsync();
