using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IYdelseService
    {
        Task<Ydelse[]?> GetAllYdelser();

        Task<Ydelse> GetYdelse(int id);

        Task<int> AddYdelse(Ydelse ydelse);

        Task<int> DeleteYdelse(int id);

        Task<int> UpdateYdelse(Ydelse ydelse);
    }
}
