﻿using EksamensProjektScooterLandBlazor.Shared.Models;
using System.Net.Http.Json;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public class OrdreService : IOrdreService
    {
        private readonly HttpClient httpClient;

        public OrdreService(HttpClient httpClient) 
        { 
            this.httpClient = httpClient;
        }

        public Task<Ordre[]?> GetAllOrdrer()
        {
            var Ordrer = httpClient.GetFromJsonAsync<Ordre[]>("api/Ordre");
            return Ordrer;
        }

        public async Task<Ordre?> GetOrdre(int id)
        {
            var Ordre = await httpClient.GetFromJsonAsync<Ordre>("api/Ordre/" + id);
            return Ordre;
        }

        public async Task<int> AddOrdre(Ordre ordre)
        {
            var svar = await httpClient.PostAsJsonAsync("api/Ordre", ordre);
            var svarStatusKode = svar.StatusCode;
            return (int)svarStatusKode;
        }

        public async Task<int> UpdateOrdre(Ordre ordre)
        {
            var svar = await httpClient.PostAsJsonAsync("api/Ordre/", ordre);
            var svarStatusKode = svar.StatusCode;
            return (int)svarStatusKode;
        }

        public async Task<int> DeleteOrdre(int id)
        {
            throw new NotImplementedException();
        }



	}
}
