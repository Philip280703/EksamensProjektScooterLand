using EksamensProjektScooterLandBlazor.Shared.Models;

namespace EksamensProjektScooterLandBlazor.Server.Repositories
{
    public interface IPostnummerOgByRepostitory
    {
        List<PostNummerOgBy> GetAllPostnummerOgByer();
        PostNummerOgBy GetPostnummerOgBy(int Postnummer);
    }
}
