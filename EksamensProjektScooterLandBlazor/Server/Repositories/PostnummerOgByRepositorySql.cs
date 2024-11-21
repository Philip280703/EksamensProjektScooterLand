using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class PostnummerOgByRepositorySql : IPostnummerOgByRepostitory
    {
        MyDbContext db = new MyDbContext();

        public List<PostNummerOgBy> GetAllPostnummerOgByer()
        {
            return db.PostNummerOgByer.ToList();
        }

        public PostNummerOgBy GetPostnummerOgBy(int Postnummer)
        {
            return db.PostNummerOgByer.Single(i => i.Postnummer == Postnummer);
        }
    }
}
