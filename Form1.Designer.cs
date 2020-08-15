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
            this.pictureBoxActive = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.General = new System.Windows.Forms.CheckBox();
            this.Anime = new System.Windows.Forms.CheckBox();
            this.People = new System.Windows.Forms.CheckBox();
            this.SFW = new System.Windows.Forms.CheckBox();
            this.Sketchy = new System.Windows.Forms.CheckBox();
            this.NSFW = new System.Windows.Forms.CheckBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.Set = new System.Windows.Forms.Button();
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
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(389, 146);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(186, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNext.Location = new System.Drawing.Point(389, 55);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(186, 33);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // General
            // 
            this.General.AutoSize = true;
            this.General.Location = new System.Drawing.Point(372, 242);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(66, 19);
            this.General.TabIndex = 3;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // Anime
            // 
            this.Anime.AutoSize = true;
            this.Anime.Location = new System.Drawing.Point(461, 242);
            this.Anime.Name = "Anime";
            this.Anime.Size = new System.Drawing.Size(61, 19);
            this.Anime.TabIndex = 4;
            this.Anime.Text = "Anime";
            this.Anime.UseVisualStyleBackColor = true;
            // 
            // People
            // 
            this.People.AutoSize = true;
            this.People.Location = new System.Drawing.Point(550, 242);
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(62, 19);
            this.People.TabIndex = 5;
            this.People.Text = "People";
            this.People.UseVisualStyleBackColor = true;
            // 
            // SFW
            // 
            this.SFW.AutoSize = true;
            this.SFW.Location = new System.Drawing.Point(372, 279);
            this.SFW.Name = "SFW";
            this.SFW.Size = new System.Drawing.Size(49, 19);
            this.SFW.TabIndex = 6;
            this.SFW.Text = "SFW";
            this.SFW.UseVisualStyleBackColor = true;
            // 
            // Sketchy
            // 
            this.Sketchy.AutoSize = true;
            this.Sketchy.Location = new System.Drawing.Point(461, 279);
            this.Sketchy.Name = "Sketchy";
            this.Sketchy.Size = new System.Drawing.Size(67, 19);
            this.Sketchy.TabIndex = 7;
            this.Sketchy.Text = "Sketchy";
            this.Sketchy.UseVisualStyleBackColor = true;
            // 
            // NSFW
            // 
            this.NSFW.AutoSize = true;
            this.NSFW.Location = new System.Drawing.Point(550, 279);
            this.NSFW.Name = "NSFW";
            this.NSFW.Size = new System.Drawing.Size(58, 19);
            this.NSFW.TabIndex = 8;
            this.NSFW.Text = "NSFW";
            this.NSFW.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(389, 197);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(186, 23);
            this.Search.TabIndex = 9;
            // 
            // Set
            // 
            this.Set.FlatAppearance.BorderSize = 0;
            this.Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Set.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Set.ForeColor = System.Drawing.Color.Aqua;
            this.Set.Location = new System.Drawing.Point(389, 105);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(186, 35);
            this.Set.TabIndex = 10;
            this.Set.Text = "Set background";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(658, 330);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NSFW);
            this.Controls.Add(this.Sketchy);
            this.Controls.Add(this.SFW);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Anime);
            this.Controls.Add(this.General);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.pictureBoxActive);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxActive;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.CheckBox General;
        private System.Windows.Forms.CheckBox Anime;
        private System.Windows.Forms.CheckBox People;
        private System.Windows.Forms.CheckBox SFW;
        private System.Windows.Forms.CheckBox Sketchy;
        private System.Windows.Forms.CheckBox NSFW;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button Set;
    }
}

