using EksamensProjektScooterLandBlazor.Client.Services;
using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class YdelseService : IYdelseService
    {
       private readonly HttpClient httpClient;

        public YdelseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Ydelse[]?> GetAllYdelser()
        {
            var result = httpClient.GetFromJsonAsync<Ydelse[]>("api/ydelseapi");
            return result;
        }

        public async Task<Ydelse?> GetYdelse(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Ydelse>("api/ydelseapi/" + id);

            return result;
        }

        public async Task<int> AddYdelse(Ydelse ydelse)
        {
            var response = await httpClient.PostAsJsonAsync("api/ydelseapi", ydelse);

            var responseStatusCode = response.StatusCode;

            return (int)responseStatusCode;
        }

        public async Task<int> DeleteYdelse(int id)
        {
            var response = await httpClient.DeleteAsync("api/ydelseapi/" + id);

            var responseStatusCode = response.StatusCode;

            return (int)responseStatusCode;
        }

        public async Task<int> UpdateYdelse(Ydelse ydelse)
        {
            var response = await httpClient.PutAsJsonAsync($"api/ydelseapi/",ydelse);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }
    }
}
