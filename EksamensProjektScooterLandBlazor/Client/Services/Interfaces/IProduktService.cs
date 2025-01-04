using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IProduktService
    {
        Task<Produkt[]?> GetAllProdukt();
        Task<Produkt> GetSingleProdukt(int id);
        Task<int> AddProdukt(Produkt produkt);
        Task<int> DeleteProdukt(int id);
        Task<int> UpdateProdukt(Produkt produkt);

    }
}
