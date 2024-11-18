using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
	public interface IProduktRepository
	{
		List<Produkt> GetAllProdukt();
		Produkt GetProdukt(int id);
		void AddProdukt (Produkt produkt);
		bool DeleteProdukt(int id);
		bool UpdateProdukt(Produkt produkt);

	}
}
