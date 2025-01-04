using EksamensProjektScooterLandBlazor.Client.Services.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class ScooterLejeService : IScooterLejeService
    {
        private readonly HttpClient httpClient;

        private string path = "api/scooterleje";

        public ScooterLejeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public async Task<ScooterLeje[]?> GetAll()
        {
            var result = await httpClient.GetFromJsonAsync<ScooterLeje[]?>(path);
            return result;
        }

        public async Task<ScooterLeje?> GetSingle(int id)
        {
            var result = await httpClient.GetFromJsonAsync<ScooterLeje>(path + "/" + id);
            return result;
        }
    }
}
