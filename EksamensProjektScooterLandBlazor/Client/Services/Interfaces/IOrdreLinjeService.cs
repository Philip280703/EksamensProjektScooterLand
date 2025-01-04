using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IOrdreLinjeService
    {
        Task<OrdreLinje[]?> GetAllOrdreLinjer();

        Task<OrdreLinje> GetOrdreLinje(int id);

        Task<int> AddOrdreLinje(OrdreLinje ordreLinje);

        Task<int> DeleteOrdreLinje(int id);

        Task<int> UpdateOrdreLinje(OrdreLinje ordreLinje);
    }
}
