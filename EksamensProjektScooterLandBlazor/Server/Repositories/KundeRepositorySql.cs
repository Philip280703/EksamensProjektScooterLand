using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class KundeRepositorySql : IKundeRepository
	{
		MyDbContext db = new MyDbContext();

        public KundeRepositorySql()
        {
            
        }

        private static readonly List<Kunde> Kundeliste;

        public void AddKunde(Kunde kunde)
        {
            db.Kunder.Add(kunde);
            db.SaveChanges();
            Console.WriteLine("saving kunde");
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
            var result = db.Kunder.Include(x=>x.Mekaniker).Include(i=>i.PostNummerOgBy).Include(l=>l.ScooterBrand).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            return result;
        }

        public Kunde FindKunde(int id)
        {
            var Kunde = db.Kunder.Single(k => k.KundeID == id);

            if (Kunde != null)
            {
                return Kunde;
            }
            Kunde = new Kunde { KundeID = -1 };
            return new Kunde();
        }

        static KundeRepositorySql()
        {
            Kundeliste = new List<Kunde>();
            Kundeliste.Clear();
            InsertTestData();
            
        }

        public static void InsertTestData()
        {
            //Kundeliste.Add(new Kunde { KundeID = 1, Fornavn = "Mark", Efternavn = "Ruge", Email = "Mark.ruge5@gmail.com", Etage = "1", HusNummer = "14", Placering = "Venstre", PostNummer = 8000, PreferetMekanikerCprNummer = "123", ScooterBrandID = 1, TelefonNummer = "29906377", VejNavn = "Chr jensensvej 14", postNummerOgBy = new PostNummerOgBy {Postnummer = 6064, ByNavn ="jordrup" });
        }
    }
}
