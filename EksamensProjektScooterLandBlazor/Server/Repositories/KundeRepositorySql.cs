using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;
namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class KundeRepositorySql : IKundeRepository
	{
		MyDbContext db = new MyDbContext();

        public KundeRepositorySql()
        {
            
        }

        public void AddKunde(Kunde kunde)
        {
            db.Kunder.Add(kunde);
            db.SaveChanges();
        }

        public bool DeleteKunde(int id)
        {
            var Kunde = db.Kunder.Single(k => k.KundeID == id);

            if (Kunde == null) // hvis kunden ikke eksistere i db så returneres false
            {
                return false;
            }
            db.Kunder.Remove(Kunde);
            db.SaveChanges();
            return true;
        }

        public bool UpdateKunde(Kunde kunde)
        {
            var currentkunde = db.Kunder.Single(k => k.KundeID == kunde.KundeID);
            if (currentkunde == null)
            {
                return false;
            }
            currentkunde.Fornavn = kunde.Fornavn; 
            currentkunde.Efternavn = kunde.Efternavn; 
            currentkunde.TelefonNummer = kunde.TelefonNummer; 
            currentkunde.VejNavn = kunde.VejNavn; 
            currentkunde.Email = kunde.Email; 
            currentkunde.PreferetMekanikerCprNummer = kunde.PreferetMekanikerCprNummer; 
            currentkunde.HusNummer = kunde.HusNummer;
            currentkunde.Etage = kunde.Etage;
            currentkunde.Placering = kunde.Placering;
            currentkunde.PostNummer = kunde.PostNummer;
            currentkunde.ScooterBrandID = kunde.ScooterBrandID;
            db.SaveChanges();
            return true;
        }

        public List<Kunde> GetAllKunder()
        {
            return db.Kunder.ToList();
        }

        public Kunde FindKunde(int id)
        {
            var Kunde = db.Kunder.Single(k => k.KundeID == id);

            if (Kunde != null)
            {
                return Kunde;
            }
            Kunde = new Kunde { KundeID = -1 };
            return Kunde;
        }
    }
}
