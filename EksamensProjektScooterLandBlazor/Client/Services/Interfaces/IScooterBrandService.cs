using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IScooterBrandService
    {
        Task<ScooterBrand[]?> GetAll();
        Task<ScooterBrand> GetSingle(int id);
    }
}
