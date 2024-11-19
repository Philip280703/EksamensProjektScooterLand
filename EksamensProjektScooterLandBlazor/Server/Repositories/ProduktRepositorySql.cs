using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class ProduktRepositorySql : IProduktRepository
	{
		MyDbContext db = new MyDbContext();

		
		public List<Produkt> GetAllProdukt()
		{
			return db.Produkter.ToList();
		}

		
		public Produkt GetProdukt(int id)
		{
			return db.Produkter.Single(i=>i.ProduktID == id);
		}

		public void AddProdukt(Produkt produkt)
		{
			db.Produkter.Add(produkt);
			db.SaveChanges();
		}

	
		public bool DeleteProdukt(int id)
		{
			var current = db.Produkter.Single(i => i.ProduktID == id);

			if (current != null)
			{
				db.Produkter.Remove(current);
				db.SaveChanges();
				return true;
			}
			return false;
		}

	
		public bool UpdateProdukt(Produkt produkt)
		{
			var current = db.Produkter.Single(i => i.ProduktID==produkt.ProduktID);

			if (current != null)
			{
				current.ProduktNavn = produkt.ProduktNavn;
				current.ProduktPris = produkt.ProduktPris;
				db.SaveChanges();
				return true;
			}
			return false;
		}


	}
}
