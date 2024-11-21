using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class PostnummerOgByService : IPostnummerOgByService
    {
        private readonly HttpClient httpClient;

        public PostnummerOgByService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<PostNummerOgBy[]?> GetAllPostnummerOgByer()
        {
            var result = httpClient.GetFromJsonAsync<PostNummerOgBy[]>("api/PostnummerOgBy");
            return result;
        }

        public async Task<PostNummerOgBy?> GetPostnummerOgBy(int Postnummer)
        {
            var result = await httpClient.GetFromJsonAsync<PostNummerOgBy>("api/PostnummerOgBy/" + Postnummer);
            return result;
        }
    }
}
