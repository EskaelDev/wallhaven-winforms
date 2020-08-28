namespace wallpaper_forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lPath = new System.Windows.Forms.Label();
            this.bSettingsSave = new System.Windows.Forms.Button();
            this.bSettingsCancel = new System.Windows.Forms.Button();
            this.chkListResolutions = new System.Windows.Forms.CheckedListBox();
            this.chkListRatios = new System.Windows.Forms.CheckedListBox();
            this.lResolution = new System.Windows.Forms.Label();
            this.lRatio = new System.Windows.Forms.Label();
            this.bChangePath = new System.Windows.Forms.Button();
            this.lSelectedPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lPath.Location = new System.Drawing.Point(80, 112);
            this.lPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(69, 32);
            this.lPath.TabIndex = 0;
            this.lPath.Text = "Path:";
            // 
            // bSettingsSave
            // 
            this.bSettingsSave.FlatAppearance.BorderSize = 0;
            this.bSettingsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettingsSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSettingsSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bSettingsSave.Location = new System.Drawing.Point(167, 638);
            this.bSettingsSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSettingsSave.Name = "bSettingsSave";
            this.bSettingsSave.Size = new System.Drawing.Size(143, 55);
            this.bSettingsSave.TabIndex = 2;
            this.bSettingsSave.Text = "Save";
            this.bSettingsSave.UseVisualStyleBackColor = true;
            this.bSettingsSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bSettingsCancel
            // 
            this.bSettingsCancel.FlatAppearance.BorderSize = 0;
            this.bSettingsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettingsCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSettingsCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bSettingsCancel.Location = new System.Drawing.Point(474, 638);
            this.bSettingsCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSettingsCancel.Name = "bSettingsCancel";
            this.bSettingsCancel.Size = new System.Drawing.Size(143, 55);
            this.bSettingsCancel.TabIndex = 2;
            this.bSettingsCancel.Text = "Cancel";
            this.bSettingsCancel.UseVisualStyleBackColor = true;
            this.bSettingsCancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // chkListResolutions
            // 
            this.chkListResolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkListResolutions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListResolutions.CheckOnClick = true;
            this.chkListResolutions.ColumnWidth = 75;
            this.chkListResolutions.ForeColor = System.Drawing.SystemColors.Menu;
            this.chkListResolutions.FormattingEnabled = true;
            this.chkListResolutions.Items.AddRange(new object[] {
            "1280x1024",
            "1280x720",
            "1280x800",
            "1280x960",
            "1600x1000",
            "1600x1200",
            "1600x1280",
            "1600x1280",
            "1600x900",
            "1920x1080",
            "1920x1200",
            "1920x1400",
            "1920x1536",
            "2560x1080",
            "2560x1440",
            "2560x1600",
            "2560x1920",
            "2560x2048",
            "3440x1440",
            "3840x1600",
            "3840x2160",
            "3840x2400",
            "3840x2880",
            "3840x3072"});
            this.chkListResolutions.Location = new System.Drawing.Point(137, 235);
            this.chkListResolutions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkListResolutions.MultiColumn = true;
            this.chkListResolutions.Name = "chkListResolutions";
            this.chkListResolutions.Size = new System.Drawing.Size(231, 336);
            this.chkListResolutions.Sorted = true;
            this.chkListResolutions.TabIndex = 3;
            this.chkListResolutions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListResolutions_ItemCheck);
            // 
            // chkListRatios
            // 
            this.chkListRatios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkListRatios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListRatios.CheckOnClick = true;
            this.chkListRatios.ForeColor = System.Drawing.Color.White;
            this.chkListRatios.FormattingEnabled = true;
            this.chkListRatios.Items.AddRange(new object[] {
            "16x9",
            "16x10",
            "21x9",
            "32x9",
            "48x9",
            "9x16",
            "10x16",
            "9x18",
            "1x1",
            "3x2",
            "4x3",
            "5x4"});
            this.chkListRatios.Location = new System.Drawing.Point(474, 235);
            this.chkListRatios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkListRatios.Name = "chkListRatios";
            this.chkListRatios.Size = new System.Drawing.Size(117, 336);
            this.chkListRatios.TabIndex = 4;
            this.chkListRatios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListRatios_ItemCheck);
            // 
            // lResolution
            // 
            this.lResolution.AutoSize = true;
            this.lResolution.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lResolution.Location = new System.Drawing.Point(137, 195);
            this.lResolution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lResolution.Name = "lResolution";
            this.lResolution.Size = new System.Drawing.Size(224, 32);
            this.lResolution.TabIndex = 0;
            this.lResolution.Text = "Resolution(at least)";
            // 
            // lRatio
            // 
            this.lRatio.AutoSize = true;
            this.lRatio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRatio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lRatio.Location = new System.Drawing.Point(496, 195);
            this.lRatio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRatio.Name = "lRatio";
            this.lRatio.Size = new System.Drawing.Size(71, 32);
            this.lRatio.TabIndex = 0;
            this.lRatio.Text = "Ratio";
            // 
            // bChangePath
            // 
            this.bChangePath.FlatAppearance.BorderSize = 0;
            this.bChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bChangePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bChangePath.Location = new System.Drawing.Point(591, 102);
            this.bChangePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bChangePath.Name = "bChangePath";
            this.bChangePath.Size = new System.Drawing.Size(120, 55);
            this.bChangePath.TabIndex = 2;
            this.bChangePath.Text = "Change";
            this.bChangePath.UseVisualStyleBackColor = true;
            this.bChangePath.Click += new System.EventHandler(this.changePath_Click);
            // 
            // lSelectedPath
            // 
            this.lSelectedPath.AccessibleName = "";
            this.lSelectedPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lSelectedPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lSelectedPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSelectedPath.ForeColor = System.Drawing.Color.Aqua;
            this.lSelectedPath.Location = new System.Drawing.Point(167, 114);
            this.lSelectedPath.Name = "lSelectedPath";
            this.lSelectedPath.Size = new System.Drawing.Size(410, 30);
            this.lSelectedPath.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AccessibleName = "lSelectedPath";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(799, 768);
            this.Controls.Add(this.lSelectedPath);
            this.Controls.Add(this.bChangePath);
            this.Controls.Add(this.lRatio);
            this.Controls.Add(this.lResolution);
            this.Controls.Add(this.chkListRatios);
            this.Controls.Add(this.chkListResolutions);
            this.Controls.Add(this.bSettingsCancel);
            this.Controls.Add(this.bSettingsSave);
            this.Controls.Add(this.lPath);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Button bSettingsSave;
        private System.Windows.Forms.Button bSettingsCancel;
        private System.Windows.Forms.CheckedListBox chkListResolutions;
        private System.Windows.Forms.CheckedListBox chkListRatios;
        private System.Windows.Forms.Label lResolution;
        private System.Windows.Forms.Label lRatio;
        private System.Windows.Forms.Button bChangePath;
        private System.Windows.Forms.TextBox lSelectedPath;
    }
}