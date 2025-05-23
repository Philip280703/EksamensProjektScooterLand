﻿using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IOrdreService
    {
        Task<Ordre[]?> GetAllOrdrer();
        Task<Ordre?> GetOrdre(int id);
        Task<int> AddOrdre(Ordre ordre);
        Task<int> UpdateOrdre(Ordre ordre);
        Task<int> DeleteOrdre(int id);
    }
}
