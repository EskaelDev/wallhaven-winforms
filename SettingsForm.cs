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
            InitComponents();
        }

        private void InitComponents()
        {
            lSelectedPath.Text = AppSettings.DirectoryPath;

            for (int i = 0; i < chkListRatios.Items.Count; i++)
            {
                if (chkListRatios.Items[i].Equals(AppSettings.Ratio))
                {
                    chkListRatios.SetItemChecked(i, true);
                    break;
                }
            }

            for (int i = 0; i < chkListResolutions.Items.Count; i++)
            {
                if (chkListResolutions.Items[i].Equals(AppSettings.LeastResolution))
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
            await AppSettings.Save(lSelectedPath.Text, chkListRatios.CheckedItems[0].ToString(), chkListResolutions.CheckedItems[0].ToString());
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
