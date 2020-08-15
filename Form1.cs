using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;
using System.Reflection;
using wallpaper_forms.Models;
using wallpaper_forms.Services;
using wallpaper_forms.Enums;

namespace wallpaper_forms
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }


        private async void nextButton_Click(object sender, EventArgs e)
        {
            await LoadWallpaper();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadWallpaper();
        }

        private async Task LoadWallpaper()
        {
            Cursor = Cursors.WaitCursor;
            Settings.Categories = RequestService.BuildCategoryString(General, Anime, People);
            Settings.Putiry = RequestService.BuildPurityString(SFW, Sketchy, NSFW);

            await DownloadWallpaper();
            Cursor = Cursors.Arrow;
        }

        private async Task DownloadWallpaper()
        {
            GlobalVariables.FullImage = null;

            await RequestService.DownloadImage(Search.Text);

            Image image = await ImageService.GetImage(GlobalVariables.ThimbNailURL);
            pictureBoxActive.Image = image;
            buttonSave.Text = "Save";
            buttonSave.Enabled = true;
        }

        private async void Set_Click(object sender, EventArgs e)
        {
            await AssureImageDownloaded();
            WallpaperService.SetWallpaper(GlobalVariables.FullImage, WallpaperService.Style.Fill);
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            await AssureImageDownloaded();
            int result = FileService.SaveImage(GlobalVariables.FullImage, $"{GlobalVariables.CurrentImageId}.png");
            if (result == 0)
            {
                buttonSave.Text = "Saved";
                buttonSave.Enabled = false;
            }
            Cursor = Cursors.Arrow;
        }

        private async Task AssureImageDownloaded()
        {
            if (GlobalVariables.FullImage is null)
                GlobalVariables.FullImage = await ImageService.GetImage(GlobalVariables.PhotoURL);
        }
    }
}
