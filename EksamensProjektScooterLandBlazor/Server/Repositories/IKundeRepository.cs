using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public interface IKundeRepository
	{
		List<Kunde> GetAllKunder();
		Kunde FindKunde(int id);
		void AddKunde(Kunde kunde);
		bool DeleteKunde(int id);
		bool UpdateKunde(Kunde kunde);
	}
}
