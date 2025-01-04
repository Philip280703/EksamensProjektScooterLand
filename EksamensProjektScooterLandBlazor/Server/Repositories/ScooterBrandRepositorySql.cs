using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class ScooterBrandRepositorySql : IScooterBrandRepository
    {
        MyDbContext db = new MyDbContext();

        public List<ScooterBrand> GetAll()
        {
            return db.ScooterBrands.ToList();
        }

        public ScooterBrand GetSingle(int id)
        {
            return db.ScooterBrands.Single(i => i.ScooterBrandID == id);
        }
    }
}
