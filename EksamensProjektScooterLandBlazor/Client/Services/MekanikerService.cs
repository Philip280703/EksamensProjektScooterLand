using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;
using Microsoft.Extensions;
using Microsoft.EntityFrameworkCore;


namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class MekanikerService : IMekanikerService
	{
		private readonly HttpClient httpClient;
		
		private string path = "api/mekaniker";

		public MekanikerService(HttpClient httpClient)
		{
			this.httpClient = httpClient;

		}

		public async Task<Mekaniker[]?> GetAllMekaniker()
		{
			var result = await httpClient.GetFromJsonAsync<Mekaniker[]?>(path);
			return result;
		}

		public async Task<Mekaniker?> GetMekaniker(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Mekaniker>(path + "/" + id);
			return result;
		}



	}
}
