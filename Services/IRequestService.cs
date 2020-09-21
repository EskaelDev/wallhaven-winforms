using System.Threading.Tasks;
using System.Windows.Forms;
using wallpaper_forms.Models;

namespace wallpaper_forms.Services
{
    public interface IRequestService
    {
        string BuildCategoryString(CheckBox General, CheckBox Anime, CheckBox People);
        string BuildPurityString(CheckBox SFW, CheckBox Sketchy, CheckBox NSFW);
        WallhavenRequest CreateRequest(string searchText);
        Task RequestImageDetails(string searchText);
    }
}