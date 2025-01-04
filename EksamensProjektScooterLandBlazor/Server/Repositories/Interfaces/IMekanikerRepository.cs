using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces
{
    public interface IMekanikerRepository
    {
        List<Mekaniker> GetAllMekaniker();

        Mekaniker GetMekaniker(int id);
    }
}
