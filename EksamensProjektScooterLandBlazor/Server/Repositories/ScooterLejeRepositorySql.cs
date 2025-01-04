using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class ScooterLejeRepositorySql : IScooterLejeRepository
    {
        MyDbContext db = new MyDbContext();

        public List<ScooterLeje> GetAll()
        {
            return db.ScooterLejer.ToList();
        }

        public ScooterLeje GetSingle(int id)
        {
            return db.ScooterLejer.Single(i => i.ScooterID == id);
        }
    }
}
