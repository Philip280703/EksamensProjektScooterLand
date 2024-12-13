using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class MekanikerRepositorySql : IMekanikerRepository
	{
		MyDbContext db = new MyDbContext();

		public List<Mekaniker> GetAllMekaniker()
		{
			return db.Mekanikere.Include(x=>x.scooterBrand).ToList();
		}

		public Mekaniker GetMekaniker(int id) 
		{ 
			return db.Mekanikere.Single(i=>int.Parse(i.CprNummer) == id);
		}
	}
}
