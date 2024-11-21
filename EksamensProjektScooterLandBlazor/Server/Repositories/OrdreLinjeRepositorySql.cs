﻿using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class OrdreLinjeRepositorySql : IOrdreLinjeRepository
	{
		MyDbContext db = new MyDbContext();

		public OrdreLinjeRepositorySql()
		{

		}

		private static readonly List<OrdreLinje> OrdreLinjeListe = new List<OrdreLinje>();

		public List<OrdreLinje> GetAllOrdreLinjer()
		{
			var result = db.OrdreLinjer.OrderBy(i => i.OrdreLinjeID).ToList();
			return result;
		}

		public OrdreLinje GetOrdreLinje(int id)
		{
			var ordreLinje = db.OrdreLinjer.Single(s => s.OrdreLinjeID == id);

			if (ordreLinje != null)
			{
				return ordreLinje;
			}

			ordreLinje = new OrdreLinje {OrdreLinjeID = -1};
			return new OrdreLinje();
		}

		public void AddOrdreLinje(OrdreLinje ordreLinje)
		{
			db.OrdreLinjer.Add(ordreLinje);
			db.SaveChanges();
			Console.WriteLine("Saving orderline");
		}

		public bool UpdateOrdreLinje(OrdreLinje ordreLinje)
		{
			var currentOrdreLinje = db.OrdreLinjer.Single(s => s.OrdreLinjeID == ordreLinje.OrdreLinjeID);
			if (currentOrdreLinje == null)
			{
				return false;
			}

			currentOrdreLinje.Antal = ordreLinje.Antal;
			currentOrdreLinje.RabatProcent = ordreLinje.RabatProcent;
			db.SaveChanges();
			return true;
		}

		public bool DeleteOrdreLinje(int id)
		{
			var ordreLinje = db.OrdreLinjer.Single(k => k.OrdreLinjeID == id);

			if (ordreLinje == null)
			{
				return false;
			}
			db.OrdreLinjer.Remove(ordreLinje);
			db.SaveChanges();
			return true;
		}
	}
}