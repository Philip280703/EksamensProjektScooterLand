using EksamensProjektScooterLandBlazor.Server.Repositories;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IKundeRepository, KundeRepositorySql>();


// tilf�j I repositoy med det givende repository her!!

builder.Services.AddScoped<IMekanikerRepository, MekanikerRepositorySql>();

builder.Services.AddScoped<IScooterBrandRepository, ScooterBrandRepositorySql>();

builder.Services.AddScoped<IYdelseRepository, YdelseRepositorySql>();

builder.Services.AddScoped<IScooterLejeRepository, ScooterLejeRepositorySql>();

builder.Services.AddScoped<IProduktRepository, ProduktRepositorySql>();

builder.Services.AddScoped<IOrdreRepository, OrdreRepositorySql>();

builder.Services.AddScoped<IOrdreLinjeRepository, OrdreLinjeRepositorySql>();

builder.Services.AddScoped<IPostnummerOgByRepostitory, PostnummerOgByRepositorySql>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
