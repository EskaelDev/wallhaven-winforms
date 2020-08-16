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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActive)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxActive
            // 
            this.pictureBoxActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBoxActive.Location = new System.Drawing.Point(26, 55);
            this.pictureBoxActive.Name = "pictureBoxActive";
            this.pictureBoxActive.Size = new System.Drawing.Size(312, 175);
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
            this.bSave.Location = new System.Drawing.Point(389, 146);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(186, 35);
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
            this.bNext.Location = new System.Drawing.Point(513, 55);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(95, 33);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // chGeneral
            // 
            this.chGeneral.AutoSize = true;
            this.chGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chGeneral.Location = new System.Drawing.Point(372, 242);
            this.chGeneral.Name = "chGeneral";
            this.chGeneral.Size = new System.Drawing.Size(63, 19);
            this.chGeneral.TabIndex = 3;
            this.chGeneral.Text = "General";
            this.chGeneral.UseVisualStyleBackColor = true;
            // 
            // chAnime
            // 
            this.chAnime.AutoSize = true;
            this.chAnime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chAnime.Location = new System.Drawing.Point(461, 242);
            this.chAnime.Name = "chAnime";
            this.chAnime.Size = new System.Drawing.Size(58, 19);
            this.chAnime.TabIndex = 4;
            this.chAnime.Text = "Anime";
            this.chAnime.UseVisualStyleBackColor = true;
            // 
            // chPeople
            // 
            this.chPeople.AutoSize = true;
            this.chPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chPeople.Location = new System.Drawing.Point(550, 242);
            this.chPeople.Name = "chPeople";
            this.chPeople.Size = new System.Drawing.Size(59, 19);
            this.chPeople.TabIndex = 5;
            this.chPeople.Text = "People";
            this.chPeople.UseVisualStyleBackColor = true;
            // 
            // chSFW
            // 
            this.chSFW.AutoSize = true;
            this.chSFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chSFW.Location = new System.Drawing.Point(372, 279);
            this.chSFW.Name = "chSFW";
            this.chSFW.Size = new System.Drawing.Size(46, 19);
            this.chSFW.TabIndex = 6;
            this.chSFW.Text = "SFW";
            this.chSFW.UseVisualStyleBackColor = true;
            // 
            // chSketchy
            // 
            this.chSketchy.AutoSize = true;
            this.chSketchy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chSketchy.Location = new System.Drawing.Point(461, 279);
            this.chSketchy.Name = "chSketchy";
            this.chSketchy.Size = new System.Drawing.Size(64, 19);
            this.chSketchy.TabIndex = 7;
            this.chSketchy.Text = "Sketchy";
            this.chSketchy.UseVisualStyleBackColor = true;
            // 
            // chNSFW
            // 
            this.chNSFW.AutoSize = true;
            this.chNSFW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chNSFW.Location = new System.Drawing.Point(550, 279);
            this.chNSFW.Name = "chNSFW";
            this.chNSFW.Size = new System.Drawing.Size(55, 19);
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
            this.inSearch.Location = new System.Drawing.Point(372, 198);
            this.inSearch.Name = "inSearch";
            this.inSearch.Size = new System.Drawing.Size(186, 20);
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
            this.bSet.Location = new System.Drawing.Point(389, 105);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(186, 35);
            this.bSet.TabIndex = 10;
            this.bSet.Text = "Set background";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.setButton_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.FlatAppearance.BorderSize = 0;
            this.bPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bPrevious.Location = new System.Drawing.Point(389, 55);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(100, 33);
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
            this.bSettings.Location = new System.Drawing.Point(606, 12);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(40, 40);
            this.bSettings.TabIndex = 11;
            this.toolTip1.SetToolTip(this.bSettings, "Settings");
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(26, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(312, 88);
            this.textBox1.TabIndex = 12;
            // 
            // bClear
            // 
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bClear.Location = new System.Drawing.Point(564, 187);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(50, 43);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(658, 330);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.textBox1);
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private TextBox textBox1;
        private Button bClear;
    }
}

