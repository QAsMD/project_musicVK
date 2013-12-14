namespace VK_MUSIC_APP
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sETTINGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AvatarUser = new System.Windows.Forms.PictureBox();
            this.lab_AudioText = new System.Windows.Forms.Label();
            this.lab_CountAudio = new System.Windows.Forms.Label();
            this.lab_NameUser = new System.Windows.Forms.Label();
            this.lab_NamePlayer = new System.Windows.Forms.Label();
            this.picBox_buttonPrev = new System.Windows.Forms.PictureBox();
            this.picBox_buttonPlay = new System.Windows.Forms.PictureBox();
            this.picBox_buttonNext = new System.Windows.Forms.PictureBox();
            this.lab_infoSong = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonPrev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonNext)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sETTINGSToolStripMenuItem,
            this.aBOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // sETTINGSToolStripMenuItem
            // 
            this.sETTINGSToolStripMenuItem.Name = "sETTINGSToolStripMenuItem";
            this.sETTINGSToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sETTINGSToolStripMenuItem.Text = "SETTINGS";
            this.sETTINGSToolStripMenuItem.Click += new System.EventHandler(this.sETTINGSToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // AvatarUser
            // 
            this.AvatarUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AvatarUser.Location = new System.Drawing.Point(12, 39);
            this.AvatarUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.AvatarUser.Name = "AvatarUser";
            this.AvatarUser.Size = new System.Drawing.Size(103, 94);
            this.AvatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarUser.TabIndex = 1;
            this.AvatarUser.TabStop = false;
            // 
            // lab_AudioText
            // 
            this.lab_AudioText.AutoSize = true;
            this.lab_AudioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_AudioText.Location = new System.Drawing.Point(121, 62);
            this.lab_AudioText.Name = "lab_AudioText";
            this.lab_AudioText.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lab_AudioText.Size = new System.Drawing.Size(222, 30);
            this.lab_AudioText.TabIndex = 3;
            this.lab_AudioText.Text = "Всего аудиозаписей:";
            // 
            // lab_CountAudio
            // 
            this.lab_CountAudio.AutoSize = true;
            this.lab_CountAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_CountAudio.Location = new System.Drawing.Point(349, 67);
            this.lab_CountAudio.Name = "lab_CountAudio";
            this.lab_CountAudio.Size = new System.Drawing.Size(130, 25);
            this.lab_CountAudio.TabIndex = 7;
            this.lab_CountAudio.Text = "count_audio";
            // 
            // lab_NameUser
            // 
            this.lab_NameUser.AutoSize = true;
            this.lab_NameUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_NameUser.Location = new System.Drawing.Point(121, 39);
            this.lab_NameUser.Name = "lab_NameUser";
            this.lab_NameUser.Size = new System.Drawing.Size(98, 23);
            this.lab_NameUser.TabIndex = 8;
            this.lab_NameUser.Text = "NameUser";
            // 
            // lab_NamePlayer
            // 
            this.lab_NamePlayer.Location = new System.Drawing.Point(267, 137);
            this.lab_NamePlayer.Name = "lab_NamePlayer";
            this.lab_NamePlayer.Size = new System.Drawing.Size(100, 22);
            this.lab_NamePlayer.TabIndex = 9;
            this.lab_NamePlayer.Text = "PlayerVK";
            this.lab_NamePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox_buttonPrev
            // 
            this.picBox_buttonPrev.Image = ((System.Drawing.Image)(resources.GetObject("picBox_buttonPrev.Image")));
            this.picBox_buttonPrev.Location = new System.Drawing.Point(182, 177);
            this.picBox_buttonPrev.Name = "picBox_buttonPrev";
            this.picBox_buttonPrev.Size = new System.Drawing.Size(79, 56);
            this.picBox_buttonPrev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_buttonPrev.TabIndex = 10;
            this.picBox_buttonPrev.TabStop = false;
            this.picBox_buttonPrev.Click += new System.EventHandler(this.picBox_buttonPrev_Click);
            // 
            // picBox_buttonPlay
            // 
            this.picBox_buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("picBox_buttonPlay.Image")));
            this.picBox_buttonPlay.Location = new System.Drawing.Point(267, 162);
            this.picBox_buttonPlay.Name = "picBox_buttonPlay";
            this.picBox_buttonPlay.Size = new System.Drawing.Size(100, 86);
            this.picBox_buttonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_buttonPlay.TabIndex = 11;
            this.picBox_buttonPlay.TabStop = false;
            this.picBox_buttonPlay.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picBox_buttonNext
            // 
            this.picBox_buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("picBox_buttonNext.Image")));
            this.picBox_buttonNext.Location = new System.Drawing.Point(373, 177);
            this.picBox_buttonNext.Name = "picBox_buttonNext";
            this.picBox_buttonNext.Size = new System.Drawing.Size(81, 56);
            this.picBox_buttonNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_buttonNext.TabIndex = 12;
            this.picBox_buttonNext.TabStop = false;
            this.picBox_buttonNext.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lab_infoSong
            // 
            this.lab_infoSong.AutoSize = true;
            this.lab_infoSong.Location = new System.Drawing.Point(12, 252);
            this.lab_infoSong.Name = "lab_infoSong";
            this.lab_infoSong.Size = new System.Drawing.Size(66, 24);
            this.lab_infoSong.TabIndex = 13;
            this.lab_infoSong.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 491);
            this.Controls.Add(this.lab_infoSong);
            this.Controls.Add(this.picBox_buttonNext);
            this.Controls.Add(this.picBox_buttonPlay);
            this.Controls.Add(this.picBox_buttonPrev);
            this.Controls.Add(this.lab_NamePlayer);
            this.Controls.Add(this.lab_NameUser);
            this.Controls.Add(this.lab_CountAudio);
            this.Controls.Add(this.lab_AudioText);
            this.Controls.Add(this.AvatarUser);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VK_MUSIC_APP(Alpha)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonPrev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buttonNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sETTINGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.PictureBox AvatarUser;
        private System.Windows.Forms.Label lab_AudioText;
        public System.Windows.Forms.Label lab_CountAudio;
        public System.Windows.Forms.Label lab_NameUser;
        private System.Windows.Forms.Label lab_NamePlayer;
        private System.Windows.Forms.PictureBox picBox_buttonPrev;
        private System.Windows.Forms.PictureBox picBox_buttonPlay;
        private System.Windows.Forms.PictureBox picBox_buttonNext;
        private System.Windows.Forms.Label lab_infoSong;

    }
}

