using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace wallpaper_forms
{
    public partial class SettingsForm : Form
    {
        int ResolutionsLastCheckedIndex = -1, RatiosLastCheckedIndex = -1;
        public SettingsForm()
        {
            InitializeComponent();
            lSelectedPath.Text = AppSettings.DirectoryPath;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string ratio, resolution;
            if (chkListRatios.CheckedItems.Count > 0)
                ratio = chkListRatios.CheckedItems[0].ToString();
            else
                ratio = AppSettings.DefaultRatio;

            if (chkListResolutions.CheckedItems.Count > 0)
                resolution = chkListResolutions.CheckedItems[0].ToString();
            else
                resolution = AppSettings.DefaultResolution;

            AppSettings.Save(lSelectedPath.Text, ratio, resolution);

            this.Close();
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
