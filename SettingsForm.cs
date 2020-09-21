using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using wallpaper_forms.Services;

namespace wallpaper_forms
{
    public partial class SettingsForm : Form
    {
        int ResolutionsLastCheckedIndex = -1, RatiosLastCheckedIndex = -1;
        private readonly IMessageBoxService _messageBoxService;
        private readonly IHost _host;

        public SettingsForm(IHost host)
        {
            _host = host;
            _messageBoxService = ActivatorUtilities.CreateInstance<MessageBoxService>(_host.Services);
            InitializeComponent();
            InitComponents();
        }

        private void InitComponents()
        {

            lSelectedPath.Text = AppConfiguration.DirectoryPath;

            for (int i = 0; i < chkListRatios.Items.Count; i++)
            {
                if (chkListRatios.Items[i].Equals(AppConfiguration.Ratio))
                {
                    chkListRatios.SetItemChecked(i, true);
                    break;
                }
            }

            for (int i = 0; i < chkListResolutions.Items.Count; i++)
            {
                if (chkListResolutions.Items[i].Equals(AppConfiguration.LeastResolution))
                {
                    chkListResolutions.SetItemChecked(i, true);
                    break;
                }
            }
            lSelectedPath.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (chkListResolutions.CheckedItems.Count <= 0)
                _messageBoxService.Show("Select resolution");
            else
            if (chkListRatios.CheckedItems.Count <= 0)
                _messageBoxService.Show("Select ratio");
            else
            {
                await AppConfiguration.Save(lSelectedPath.Text, chkListRatios.CheckedItems[0].ToString(), chkListResolutions.CheckedItems[0].ToString());
                this.Close();
            }
        }

        private void changePath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            lSelectedPath.Text = folderBrowserDialog1.SelectedPath;
        }
        private void chkListResolutions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SelectOneCheckboxInList((CheckedListBox)sender, e, ref ResolutionsLastCheckedIndex);
        }
        private void chkListRatios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SelectOneCheckboxInList((CheckedListBox)sender, e, ref RatiosLastCheckedIndex);
        }

        private void openPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", AppConfiguration.DirectoryPath);
        }

        private void SelectOneCheckboxInList(CheckedListBox listBox, ItemCheckEventArgs e, ref int lastIndex)
        {
            if (e.Index != lastIndex)
            {
                if (lastIndex != -1)
                    listBox.SetItemCheckState(lastIndex, CheckState.Unchecked);
                lastIndex = e.Index;
            }
        }
    }
}
