using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public interface IScooterBrandService
    {
        Task<ScooterBrand[]?> GetAll();
        Task<ScooterBrand> GetSingle(int id);
    }
}
