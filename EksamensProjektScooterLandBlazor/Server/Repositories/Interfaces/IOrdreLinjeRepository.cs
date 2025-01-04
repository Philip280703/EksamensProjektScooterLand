using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces
{
    public interface IOrdreLinjeRepository
    {
        List<OrdreLinje> GetAllOrdreLinjer();
        OrdreLinje GetOrdreLinje(int id);
        void AddOrdreLinje(OrdreLinje ordreLinje);
        bool DeleteOrdreLinje(int id);
        bool UpdateOrdreLinje(OrdreLinje ordreLinje);
    }
}
