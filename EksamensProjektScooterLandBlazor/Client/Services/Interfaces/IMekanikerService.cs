using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IMekanikerService
    {
        Task<Mekaniker[]?> GetAllMekaniker();
        Task<Mekaniker> GetMekaniker(int id);

    }
}
