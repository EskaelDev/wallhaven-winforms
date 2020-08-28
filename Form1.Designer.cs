using System.Drawing;
using System.Windows.Forms;

namespace wallpaper_forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxActive = new System.Windows.Forms.PictureBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.chGeneral = new System.Windows.Forms.CheckBox();
            this.chAnime = new System.Windows.Forms.CheckBox();
            this.chPeople = new System.Windows.Forms.CheckBox();
            this.chSFW = new System.Windows.Forms.CheckBox();
            this.chSketchy = new System.Windows.Forms.CheckBox();
            this.chNSFW = new System.Windows.Forms.CheckBox();
            this.inSearch = new System.Windows.Forms.TextBox();
            this.bSet = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.txtBoxResolution = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActive)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxActive
            // 
            this.pictureBoxActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxActive.Location = new System.Drawing.Point(37, 92);
            this.pictureBoxActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxActive.Name = "pictureBoxActive";
            this.pictureBoxActive.Size = new System.Drawing.Size(446, 292);
            this.pictureBoxActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxActive.TabIndex = 0;
            this.pictureBoxActive.TabStop = false;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bSave.Location = new System.Drawing.Point(556, 243);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(266, 58);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bNext
            // 
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bNext.Location = new System.Drawing.Point(733, 92);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(136, 55);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // chGeneral
            // 
            this.chGeneral.AutoSize = true;
            this.chGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chGeneral.Location = new System.Drawing.Point(531, 403);
            this.chGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chGeneral.Name = "chGeneral";
            this.chGeneral.Size = new System.Drawing.Size(92, 29);
            this.chGeneral.TabIndex = 3;
            this.chGeneral.Text = "General";
            this.chGeneral.UseVisualStyleBackColor = true;
            // 
            // chAnime
            // 
            this.chAnime.AutoSize = true;
            this.chAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chAnime.Location = new System.Drawing.Point(659, 403);
            this.chAnime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chAnime.Name = "chAnime";
            this.chAnime.Size = new System.Drawing.Size(84, 29);
            this.chAnime.TabIndex = 4;
            this.chAnime.Text = "Anime";
            this.chAnime.UseVisualStyleBackColor = true;
            // 
            // chPeople
            // 
            this.chPeople.AutoSize = true;
            this.chPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chPeople.Location = new System.Drawing.Point(786, 403);
            this.chPeople.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chPeople.Name = "chPeople";
            this.chPeople.Size = new System.Drawing.Size(86, 29);
            this.chPeople.TabIndex = 5;
            this.chPeople.Text = "People";
            this.chPeople.UseVisualStyleBackColor = true;
            // 
            // chSFW
            // 
            this.chSFW.AutoSize = true;
            this.chSFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chSFW.Location = new System.Drawing.Point(531, 465);
            this.chSFW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chSFW.Name = "chSFW";
            this.chSFW.Size = new System.Drawing.Size(69, 29);
            this.chSFW.TabIndex = 6;
            this.chSFW.Text = "SFW";
            this.chSFW.UseVisualStyleBackColor = true;
            // 
            // chSketchy
            // 
            this.chSketchy.AutoSize = true;
            this.chSketchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chSketchy.Location = new System.Drawing.Point(659, 465);
            this.chSketchy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chSketchy.Name = "chSketchy";
            this.chSketchy.Size = new System.Drawing.Size(94, 29);
            this.chSketchy.TabIndex = 7;
            this.chSketchy.Text = "Sketchy";
            this.chSketchy.UseVisualStyleBackColor = true;
            // 
            // chNSFW
            // 
            this.chNSFW.AutoSize = true;
            this.chNSFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chNSFW.Location = new System.Drawing.Point(786, 465);
            this.chNSFW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chNSFW.Name = "chNSFW";
            this.chNSFW.Size = new System.Drawing.Size(82, 29);
            this.chNSFW.TabIndex = 8;
            this.chNSFW.Text = "NSFW";
            this.chNSFW.UseVisualStyleBackColor = true;
            // 
            // inSearch
            // 
            this.inSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inSearch.ForeColor = System.Drawing.Color.Aqua;
            this.inSearch.Location = new System.Drawing.Point(531, 330);
            this.inSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inSearch.Name = "inSearch";
            this.inSearch.Size = new System.Drawing.Size(266, 30);
            this.inSearch.TabIndex = 9;
            this.inSearch.Text = "Search...";
            this.inSearch.WordWrap = false;
            this.inSearch.GotFocus += new System.EventHandler(this.inSearch_GetFocus);
            this.inSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inSearch_KeyDown);
            this.inSearch.LostFocus += new System.EventHandler(this.inSearch_LostFocus);
            // 
            // bSet
            // 
            this.bSet.FlatAppearance.BorderSize = 0;
            this.bSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bSet.ForeColor = System.Drawing.Color.Aqua;
            this.bSet.Location = new System.Drawing.Point(556, 175);
            this.bSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(266, 58);
            this.bSet.TabIndex = 10;
            this.bSet.Text = "Set background";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.setButton_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Enabled = false;
            this.bPrevious.FlatAppearance.BorderSize = 0;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bPrevious.Location = new System.Drawing.Point(556, 92);
            this.bPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(143, 55);
            this.bPrevious.TabIndex = 2;
            this.bPrevious.Text = "Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSettings.BackgroundImage")));
            this.bSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSettings.FlatAppearance.BorderSize = 0;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSettings.Location = new System.Drawing.Point(866, 20);
            this.bSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(57, 67);
            this.bSettings.TabIndex = 11;
            this.toolTip1.SetToolTip(this.bSettings, "Settings");
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxDescription.Location = new System.Drawing.Point(37, 393);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.ReadOnly = true;
            this.txtBoxDescription.Size = new System.Drawing.Size(446, 147);
            this.txtBoxDescription.TabIndex = 12;
            // 
            // bClear
            // 
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bClear.Location = new System.Drawing.Point(806, 312);
            this.bClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(71, 72);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // txtBoxResolution
            // 
            this.txtBoxResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtBoxResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxResolution.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBoxResolution.Location = new System.Drawing.Point(37, 42);
            this.txtBoxResolution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxResolution.Multiline = true;
            this.txtBoxResolution.Name = "txtBoxResolution";
            this.txtBoxResolution.ReadOnly = true;
            this.txtBoxResolution.Size = new System.Drawing.Size(446, 45);
            this.txtBoxResolution.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(940, 550);
            this.Controls.Add(this.txtBoxResolution);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.inSearch);
            this.Controls.Add(this.chNSFW);
            this.Controls.Add(this.chSketchy);
            this.Controls.Add(this.chSFW);
            this.Controls.Add(this.chPeople);
            this.Controls.Add(this.chAnime);
            this.Controls.Add(this.chGeneral);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.pictureBoxActive);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallhaven";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxActive;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.CheckBox chGeneral;
        private System.Windows.Forms.CheckBox chAnime;
        private System.Windows.Forms.CheckBox chPeople;
        private System.Windows.Forms.CheckBox chSFW;
        private System.Windows.Forms.CheckBox chSketchy;
        private System.Windows.Forms.CheckBox chNSFW;
        private System.Windows.Forms.TextBox inSearch;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bSettings;
        private ToolTip toolTip1;
        private TextBox txtBoxDescription;
        private Button bClear;
        private TextBox txtBoxResolution;
    }
}

