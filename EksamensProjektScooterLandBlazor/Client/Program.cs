using EksamensProjektScooterLandBlazor.Client;
using EksamensProjektScooterLandBlazor.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// måske unødvendig
builder.Services.AddScoped<IYdelseService, YdelseService>();


await builder.Build().RunAsync();
