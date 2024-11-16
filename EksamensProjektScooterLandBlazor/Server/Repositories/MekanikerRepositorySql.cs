using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class MekanikerRepositorySql : IMekanikerRepository
	{
		MyDbContext db = new MyDbContext();

		public List<Mekaniker> GetAllMekaniker()
		{
			return db.Mekanikere.ToList();
		}

		public Mekaniker GetMekaniker(int id) 
		{ 
			return db.Mekanikere.Single(i=>int.Parse(i.CprNummer) == id);
		}
	}
}
