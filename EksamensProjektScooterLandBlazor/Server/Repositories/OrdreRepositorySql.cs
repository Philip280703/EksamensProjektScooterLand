using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class OrdreRepositorySql : IOrdreRepository
    {
        MyDbContext db = new MyDbContext();

        public OrdreRepositorySql()
        {

        }

        private static readonly List<Ordre> Ordreliste;

        public void AddOrdre(Ordre Ordre)
        {
            db.Ordrer.Add(Ordre);
            db.SaveChanges();
            Console.WriteLine("saving Ordre");
        }

      

        public bool UpdateOrdre(Ordre Ordre)
        {
            var currentOrdre = db.Ordrer.Single(k => k.OrdreID == Ordre.OrdreID);
            if (currentOrdre == null)
            {
                return false;
            }
            currentOrdre.MedarbejderCpr = Ordre.MedarbejderCpr;
            currentOrdre.SamletPris = Ordre.SamletPris;
            
           
            db.SaveChanges();
            return true;
        }

        public List<Ordre> GetAllOrdrer()
        {
            var result = db.Ordrer.OrderBy(s => s.OrdreID).ToList();
            return result;
        }

        public Ordre FindOrdre(int id)
        {
            var ordre = db.Ordrer.Single(k => k.OrdreID == id);

            if (ordre != null)
            {
                return ordre;
            }
            ordre = new Ordre { OrdreID = -1 };
            return new Ordre();
        }

        
    }
}
