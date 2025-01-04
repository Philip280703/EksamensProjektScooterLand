using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.Identity.Client;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public class YdelseRepositorySql : IYdelseRepository
    {
        MyDbContext db = new MyDbContext();

        
        public List<Ydelse> GetAllYdelser()
        {
            return db.Ydelser.ToList();
        }

        public Ydelse GetYdelse(int id)
        {
            return db.Ydelser.Single(i => i.YdelseID == id);
        }

        public void AddYdelse(Ydelse ydelse)
        {
            db.Ydelser.Add(ydelse);
            db.SaveChanges();
        }

        public bool DeleteYdelse(int id)
        {
            var current = db.Ydelser.Single(i=> i.YdelseID == id);
            if (current != null)
            {
                db.Ydelser.Remove(current);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateYdelse(Ydelse ydelse)
        {
            var current = db.Ydelser.Single(i => i.YdelseID == ydelse.YdelseID);
            if (current != null)
            {
                current.YdelseNavn = ydelse.YdelseNavn;
                current.Pris = ydelse.Pris;
                current.EstimeretTid = ydelse.EstimeretTid;
                db.SaveChanges();   
                return true;
            }
            return false;
        }
    }
}
