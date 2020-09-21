using System.Threading.Tasks;

namespace wallpaper_forms.Services
{
    public interface IWallhavenApiService
    {
        Task<string> Get(string Uri, string body);
    }
}