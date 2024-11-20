using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public interface IOrdreRepository
    {
        List<Ordre> GetAllOrdrer();
        Ordre FindOrdre(int id);
        void AddOrdre(Ordre ordre);
        bool DeleteOrdre(int id);
        bool UpdateOrdre(Ordre ordre);
    }
}
