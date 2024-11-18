using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public interface IMekanikerService
    {
        Task<Mekaniker[]?> GetAllMekaniker();
        Task<Mekaniker> GetMekaniker(int id);

    }
}
