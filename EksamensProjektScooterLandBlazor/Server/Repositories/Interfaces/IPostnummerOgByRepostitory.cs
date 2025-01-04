using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories.Interfaces
{
    public interface IPostnummerOgByRepostitory
    {
        List<PostNummerOgBy> GetAllPostnummerOgByer();
        PostNummerOgBy GetPostnummerOgBy(int Postnummer);
    }
}
