using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public interface IMekanikerRepository
	{
		List<Mekaniker> GetAllMekaniker();

		Mekaniker GetMekaniker(int id);
	}
}
