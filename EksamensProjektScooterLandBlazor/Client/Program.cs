using Blazored.LocalStorage;
using EksamensProjektScooterLandBlazor.Client;
using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<IKundeService, KundeService>(client =>
{
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IMekanikerService, MekanikerService>(client =>
{
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IScooterBrandService, ScooterBrandService>(client =>
{
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IYdelseService, YdelseService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IScooterLejeService, ScooterLejeService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IProduktService, ProduktService>(client =>
{
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IOrdreService, OrdreService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddHttpClient<IOrdreLinjeService, OrdreLinjeService>(client =>
{
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});


builder.Services.AddHttpClient<IPostnummerOgByService, PostnummerOgByService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});

builder.Services.AddBlazoredLocalStorage();



await builder.Build().RunAsync();
