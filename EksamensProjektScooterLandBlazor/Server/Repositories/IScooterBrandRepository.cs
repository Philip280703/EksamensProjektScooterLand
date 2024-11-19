using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public interface IScooterBrandRepository
    {
        List<ScooterBrand> GetAll();

        ScooterBrand GetSingle(int id);
    }
}
