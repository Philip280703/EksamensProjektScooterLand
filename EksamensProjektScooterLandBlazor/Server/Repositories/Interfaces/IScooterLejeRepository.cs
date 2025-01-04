using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces
{
    public interface IScooterLejeRepository
    {
        List<ScooterLeje> GetAll();

        ScooterLeje GetSingle(int id);
    }
}
