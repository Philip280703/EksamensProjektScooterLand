using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
	public class OrdreLinjeService : IOrdreLinjeService
	{
		private readonly HttpClient httpClient;

		public OrdreLinjeService(HttpClient httpClient)
		{
				this.httpClient = httpClient;
		}

		public Task<OrdreLinje[]?> GetAllOrdreLinjer()
		{
			var ordreLinjer = httpClient.GetFromJsonAsync<OrdreLinje[]>("api/ordrelinjeapi");
			return ordreLinjer;
		}

		public async Task<OrdreLinje?> GetOrdreLinje(int id)
		{
			var ordreLinje = await httpClient.GetFromJsonAsync<OrdreLinje>("api/ordrelinjeapi/" + id);
			return ordreLinje;
		}

		public async Task<int> AddOrdreLinje(OrdreLinje ordreLinje)
		{
			var svar = await httpClient.PostAsJsonAsync("api/ordrelinjeapi", ordreLinje);
			var svarStatusCode = svar.StatusCode;
			return (int)svarStatusCode;
		}

		public async Task<int> DeleteOrdreLinje(int id)
		{
			var svar = await httpClient.DeleteAsync("api/ordrelinjeapi/" +  id);
			var svarStatusCode = svar.StatusCode;
			return (int)svarStatusCode;
		}
		
		public async Task<int> UpdateOrdreLinje(OrdreLinje ordreLinje)
		{
			var svar = await httpClient.PostAsJsonAsync("api/ordrelinjeapi", ordreLinje);
			var svarStatusCode = svar.StatusCode;
			return (int)svarStatusCode;
		}

	}
}
