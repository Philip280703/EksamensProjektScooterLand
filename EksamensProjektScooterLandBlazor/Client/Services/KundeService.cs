using System.Net.Http.Json;
using EksamensProjektScooterLandBlazor.Client.Services;
namespace EksamensProjektScooterLandBlazor.Shared.Models;

	public class KundeService : IKundeService
	{
    private readonly HttpClient httpClient;
    public KundeService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public Task<Kunde[]?> GetAllKunder()
    {
        var kunder = httpClient.GetFromJsonAsync<Kunde[]>("api/kundeapi");
        return kunder;
    }

    public async Task<Kunde?> GetKunde(int id)
    {
        var kunde = await httpClient.GetFromJsonAsync<Kunde>("api/kundeapi/" + id);
        return kunde;
    }

    public async Task<int> AddKunde(Kunde kunde)
    {
        var svar = await httpClient.PostAsJsonAsync("api/kundeapi", kunde);
        var svarStatusKode = svar.StatusCode;
        return (int)svarStatusKode;
    }

    public async Task<int> DeleteKunde(int id)
    {
        var svar = await httpClient.DeleteAsync("api/kundeapi/" + id);
        var svarStatusKode = svar.StatusCode;
        return (int)svarStatusKode;
    }

    public async Task<int> UpdateKunde(Kunde kunde)
    {
        var svar = await httpClient.PutAsJsonAsync("api/kundeapi/", kunde);
        var svarStatusKode = svar.StatusCode;
        return (int)svarStatusKode;
    }
}
