using Dndprojectv1.Client;
using Dndprojectv1.Shared;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://www.dnd5eapi.co/api/")
    });
builder.Services.AddScoped<JsonService>();

await builder.Build().RunAsync();
