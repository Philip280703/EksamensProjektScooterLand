using EksamensProjektScooterLandBlazor.Server.DataAccess;
using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public class MekanikerRepositorySql : IMekanikerRepository
	{
		MyDbContext db = new MyDbContext();

		/// <summary>
		/// from MekanikerRepositorySql
		/// </summary>
		/// <returns></returns>
		public List<Mekaniker> GetAllMekaniker()
		{
			return db.Mekanikere.ToList();
		}

		/// <summary>
		/// from MekanikerRepositorySql
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Mekaniker GetMekaniker(int id) 
		{ 
			return db.Mekanikere.Single(i=>int.Parse(i.CprNummer) == id);
		}
	}
}
