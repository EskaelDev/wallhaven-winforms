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
            InitComponents();
        }

        private void InitComponents()
        {
            chNSFW.Enabled = GlobalVariables.Logged;
            inSearch.Text = GlobalVariables.SearchBoxPlaceholderText;
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
            AppSettings.Categories = RequestService.BuildCategoryString(chGeneral, chAnime, chPeople);
            AppSettings.Putiry = RequestService.BuildPurityString(chSFW, chSketchy, chNSFW);

            await DownloadWallpaper();
            Cursor = Cursors.Arrow;
        }

        private async Task DownloadWallpaper()
        {
            GlobalVariables.FullImage = null;

            if (inSearch.Text.Equals(GlobalVariables.SearchBoxPlaceholderText))
                await RequestService.RequestImageDetails("");
            else
                await RequestService.RequestImageDetails(inSearch.Text);

            Image image = await ImageService.GetImage(GlobalVariables.ThumbnailURL);
            pictureBoxActive.Image = image;
            textBox1.Text = GlobalVariables.CurrentImageDetails;
            bSave.Text = "Save";
            bSave.Enabled = true;
        }

        private async void setButton_Click(object sender, EventArgs e)
        {
            await AssureImageDownloaded();
            WallpaperService.SetWallpaper(GlobalVariables.FullImage, WallpaperService.Style.Fill);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            await AssureImageDownloaded();
            int result = FileService.SaveImage(GlobalVariables.FullImage, $"{GlobalVariables.CurrentImageId}.png");
            if (result == 0)
            {
                bSave.Text = "Saved";
                bSave.Enabled = false;
            }
            Cursor = Cursors.Arrow;
        }

        private async Task AssureImageDownloaded()
        {
            if (GlobalVariables.FullImage is null)
                GlobalVariables.FullImage = await ImageService.GetImage(GlobalVariables.PhotoURL);
        }

        private void inSearch_GetFocus(object sender, EventArgs e)
        {
            var txtBox = (TextBox)sender;
            if (txtBox.Text.Equals(GlobalVariables.SearchBoxPlaceholderText))
                txtBox.Text = "";
        }

        private void inSearch_LostFocus(object sender, EventArgs e)
        {
            if (inSearch.Text.Length <= 0)
                ClearSearchInput();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSearchInput();
        }
        private void ClearSearchInput()
        {
            inSearch.Text = GlobalVariables.SearchBoxPlaceholderText;
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                settings.ShowDialog(this);
            }
        }

        private void inSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bNext.PerformClick();
        }
    }
}
