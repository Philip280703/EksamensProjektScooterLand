using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class ScooterBrandRepositorySql : IScooterBrandRepository
    {
        MyDbContext db = new MyDbContext();

        /// <summary>
        /// from ScooterbrandRepositorySql
        /// </summary>
        /// <returns></returns>
        public List<ScooterBrand> GetAll()
        {
            return db.ScooterBrands.ToList();
        }

        /// <summary>
        /// from ScooterbrandRepositorySql
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ScooterBrand GetSingle(int id)
        {
            return db.ScooterBrands.Single(i => i.ScooterBrandID == id);
        }
    }
}
