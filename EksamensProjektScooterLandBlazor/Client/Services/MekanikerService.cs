using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;
using Microsoft.Extensions;

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

		/// <summary>
		/// from mekanikerService
		/// </summary>
		/// <returns></returns>
		public async Task<Mekaniker[]?> GetAllMekaniker()
		{
			var result = await httpClient.GetFromJsonAsync<Mekaniker[]?>(path);
			return result;
		}


		/// <summary>
		/// from mekanikerService
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public async Task<Mekaniker?> GetMekaniker(int id)
		{
			var result = await httpClient.GetFromJsonAsync<Mekaniker>(path + "/" + id);
			return result;
		}
		

	}
}
