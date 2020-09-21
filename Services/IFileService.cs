using System.Drawing;

namespace wallpaper_forms.Services
{
    public interface IFileService
    {
        int SaveImage(Image img, string fileName);
    }
}