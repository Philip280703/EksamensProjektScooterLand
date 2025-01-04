using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services.Interfaces
{
    public interface IPostnummerOgByService
    {
        Task<PostNummerOgBy[]?> GetAllPostnummerOgByer();
        Task<PostNummerOgBy?> GetPostnummerOgBy(int Postnummer);
    }
}
