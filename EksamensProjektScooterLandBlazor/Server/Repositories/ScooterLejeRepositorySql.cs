using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class ScooterLejeRepositorySql : IScooterLejeRepository
    {
        MyDbContext db = new MyDbContext();

        /// <summary>
        /// from ScooterLejeRepositorySql
        /// </summary>
        /// <returns></returns>
        public List<ScooterLeje> GetAll()
        {
            return db.ScooterLejer.ToList();
        }

        /// <summary>
        /// from ScooterLejeRepositorySql
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ScooterLeje GetSingle(int id)
        {
            return db.ScooterLejer.Single(i => i.ScooterID == id);
        }
    }
}
