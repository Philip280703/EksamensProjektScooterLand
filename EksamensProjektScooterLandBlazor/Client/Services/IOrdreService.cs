using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public interface IOrdreService
    {
        Task<Ordre[]?> GetAllOrdrer();
        Task<Ordre?> GetOrdre(int id);
        Task<int> AddOrdre(Ordre ordre);
        Task<int> UpdateOrdre(Ordre ordre);
    }
}
