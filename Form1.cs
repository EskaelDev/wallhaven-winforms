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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace wallpaper_forms
{
    public partial class MainForm : Form
    {
        private Point location;
        private int imageIndex;
        private readonly IRequestService _requestService;
        private readonly IImageService _imageService;
        private readonly IMessageBoxService _messageBoxService;
        private readonly IFileService _fileService;
        private readonly IWallpaperService _wallpaperService;
        private readonly IWallhavenApiService _wallhavenApiService;



        private readonly IHost _host;

        public MainForm(IHost host)
        {
            InitializeComponent();
            InitComponents();
            _host = host;
            _requestService = ActivatorUtilities.CreateInstance<RequestService>(_host.Services);
            _imageService = ActivatorUtilities.CreateInstance<ImageService>(_host.Services);
            _messageBoxService = ActivatorUtilities.CreateInstance<MessageBoxService>(_host.Services);
            _fileService = ActivatorUtilities.CreateInstance<FileService>(_host.Services);
            _wallpaperService = ActivatorUtilities.CreateInstance<WallpaperService>(_host.Services);
            _wallhavenApiService = ActivatorUtilities.CreateInstance<WallhavenApiService>(_host.Services);

        }

        private async void InitComponents()
        {
            GlobalVariables.Visited = new System.Collections.Generic.List<ImageDetails>();
            imageIndex = 0;
            bPrevious.Enabled = false;
            largePicture.Visible = false;
            largePicture.SizeMode = PictureBoxSizeMode.Zoom;
            await AppConfiguration.CreateDefaultOnStartup();
            AppConfiguration.LoadFromFile();
            chNSFW.Enabled = GlobalVariables.Logged;
            inSearch.Text = GlobalVariables.SearchBoxPlaceholderText;
            txtBoxResolution.Text = ("Current resolution: " + GlobalVariables.screenWidth + "x" + GlobalVariables.screenHeight);
        }

        private async void nextButton_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (GlobalVariables.Visited.Count <= imageIndex)
                await LoadWallpaper();
            else
            {
                GlobalVariables.CurrentImage = GlobalVariables.Visited[imageIndex];
                ApplyImage();
            }
            bPrevious.Enabled = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadWallpaper();
        }

        private async Task LoadWallpaper()
        {
            Cursor = Cursors.WaitCursor;
            AppConfiguration.Categories = _requestService.BuildCategoryString(chGeneral, chAnime, chPeople);
            AppConfiguration.Putiry = _requestService.BuildPurityString(chSFW, chSketchy, chNSFW);

            await DownloadWallpaper();
            Cursor = Cursors.Arrow;
        }

        private async Task DownloadWallpaper()
        {
            GlobalVariables.FullImage = null;

            if (inSearch.Text.Equals(GlobalVariables.SearchBoxPlaceholderText))
                await _requestService.RequestImageDetails("");
            else
                await _requestService.RequestImageDetails(inSearch.Text);



            GlobalVariables.CurrentImage.Thumbnail = await _imageService.GetImage(GlobalVariables.CurrentImage.ThumbnailURL);
            ApplyImage();
            bSave.Text = "Save";
            bSave.Enabled = true;
        }

        private async void setButton_Click(object sender, EventArgs e)
        {
            await AssureImageDownloaded();
            _wallpaperService.SetWallpaper(GlobalVariables.FullImage, WallpaperService.Style.Fill);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            await AssureImageDownloaded();
            int result = _fileService.SaveImage(GlobalVariables.FullImage, $"{GlobalVariables.CurrentImage.Id}.png");
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
                GlobalVariables.FullImage = await _imageService.GetImage(GlobalVariables.CurrentImage.PhotoURL);
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
            using (SettingsForm settings = new SettingsForm(_host))
            {
                settings.ShowDialog(this);
            }
        }

        private void inSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bNext.PerformClick();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private async void pictureBoxActive_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (pictureBoxActive.Image is null)
                return;

            Image image = await _imageService.GetImage(GlobalVariables.CurrentImage.PhotoURL);

            GlobalVariables.FullImage = image;

            this.MaximumSize = largePicture.MaximumSize = new Size(int.Parse(GlobalVariables.screenWidth) - 500, int.Parse(GlobalVariables.screenWidth) - 500);

            this.Width = image.Width;
            this.Height = image.Height;
            largePicture.Width = this.Width;
            largePicture.Height = this.Height;

            largePicture.Image = image;
            largePicture.Visible = true;

            location = this.Location;
            this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2 - largePicture.Width / 2, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height / 2 - largePicture.Height / 2);
            Cursor = Cursors.Arrow;
        }

        private void largePicture_Click(object sender, EventArgs e)
        {
            largePicture.Image = null;
            largePicture.Visible = false;

            this.Width = AppConfiguration.MainFormWidth;
            this.Height = AppConfiguration.MainFormHeight;

            this.Location = location;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            imageIndex--;

            if (imageIndex >= 0)
            {
                GlobalVariables.CurrentImage = GlobalVariables.Visited[imageIndex];
                GlobalVariables.FullImage = null;
                ApplyImage();
            }
            if (imageIndex <= 0)
                bPrevious.Enabled = false;
        }

        private void ApplyImage()
        {
            pictureBoxActive.Image = GlobalVariables.CurrentImage.Thumbnail;
            txtBoxDescription.Text = GlobalVariables.CurrentImage.Description;
        }
    }
}