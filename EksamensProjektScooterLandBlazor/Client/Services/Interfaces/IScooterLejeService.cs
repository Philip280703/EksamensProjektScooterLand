using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IScooterLejeService
    {
        Task<ScooterLeje[]?> GetAll();
        Task<ScooterLeje?> GetSingle(int id);

    }
}
