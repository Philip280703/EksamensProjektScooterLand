using EksamensProjektScooterLandBlazor.Shared.Models;
using EksamensProjektScooterLandBlazor.Client.Services;


namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public interface IYdelseRepository
    {
        List<Ydelse> GetAllYdelser();
        Ydelse GetYdelse(int id);
        
        void AddYdelse(Ydelse ydelse);
        bool DeleteYdelse(int id);
        bool UpdateYdelse(Ydelse ydelse);

    }
}
