using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Client.Services
{
    public interface IPostnummerOgByService
    {
        Task<PostNummerOgBy[]?> GetAllPostnummerOgByer();
        Task<PostNummerOgBy?> GetPostnummerOgBy(int Postnummer);
    }
}
