using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public interface IScooterLejeService
    {
        Task<ScooterLeje[]?> GetAll();
        Task<ScooterLeje?> GetSingle(int id);
        
    }
}
