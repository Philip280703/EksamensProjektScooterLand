using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
	public class ProduktService : IProduktService
	{
		private readonly HttpClient httpClient;

		private string path = "api/produktapi";

		public ProduktService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

	public async Task<Produkt[]?> GetAllProdukt()
		{
			var result = await httpClient.GetFromJsonAsync<Produkt[]?>(path);
			return result;
		}

		public async Task<Produkt> GetSingleProdukt(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Produkt>(path + "/" + id);
			return result;
		}

		public async Task<int> AddProdukt(Produkt produkt)
		{
			var result = await httpClient.PostAsJsonAsync(path,produkt);
			var resultStatusCode = result.StatusCode;
			return (int)resultStatusCode;
		}

		public async Task<int> DeleteProdukt(int id)
		{
			var result = await httpClient.DeleteAsync(path + "/" + id);
			var resultStatusCode = result.StatusCode;
			return (int)resultStatusCode;
		}

		public async Task<int> UpdateProdukt(Produkt produkt)
		{
			var response = await httpClient.PutAsJsonAsync($"api/produktapi",produkt);
			var responseStatusCode = response.StatusCode;
			return (int)responseStatusCode;
		}

	}
}
