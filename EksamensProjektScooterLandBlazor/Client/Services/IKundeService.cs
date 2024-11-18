using EksamensProjektScooterLandBlazor.Shared.Models;
namespace EksamensProjektScooterLandBlazor.Client.Services
{
	public interface IKundeService
	{
		Task<Kunde[]?> GetAllKunder();
		Task<Kunde?> GetKunde(int id);
		Task<int> AddKunde(Kunde kunde);
		Task<int> DeleteKunde(int id);
		Task<int> UpdateKunde(Kunde kunde);
	}
}
