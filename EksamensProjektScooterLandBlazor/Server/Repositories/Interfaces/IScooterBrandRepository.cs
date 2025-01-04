using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces
{
    public interface IScooterBrandRepository
    {
        List<ScooterBrand> GetAll();

        ScooterBrand GetSingle(int id);
    }
}
