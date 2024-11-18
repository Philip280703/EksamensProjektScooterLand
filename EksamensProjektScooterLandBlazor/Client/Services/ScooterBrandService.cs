using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class ScooterBrandService : IScooterBrandService
    {
        private readonly HttpClient httpClient;

        private string path = "api/scooterbrand";

        public ScooterBrandService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        /// <summary>
        /// from ScooterbrandService
        /// </summary>
        /// <returns></returns>
        public async Task<ScooterBrand[]?> GetAll()
        {
            var result = await httpClient.GetFromJsonAsync<ScooterBrand[]?>(path);
            return result;
        }


        /// <summary>
        /// from ScooterbrandService
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ScooterBrand?> GetSingle(int id)
        {
            var result = await httpClient.GetFromJsonAsync<ScooterBrand>(path + "/" + id);
            return result;
        }
    }
}
