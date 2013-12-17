namespace VK_MUSIC_APP
{
    partial class FormPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaylist));
            this.listBox_Playlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_Playlist
            // 
            this.listBox_Playlist.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Playlist.FormattingEnabled = true;
            this.listBox_Playlist.ItemHeight = 23;
            this.listBox_Playlist.Location = new System.Drawing.Point(12, 12);
            this.listBox_Playlist.Name = "listBox_Playlist";
            this.listBox_Playlist.Size = new System.Drawing.Size(426, 326);
            this.listBox_Playlist.TabIndex = 0;
            this.listBox_Playlist.SelectedIndexChanged += new System.EventHandler(this.listBox_Playlist_SelectedIndexChanged);
            // 
            // FormPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 351);
            this.Controls.Add(this.listBox_Playlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlaylist";
            this.Text = "Playlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Playlist;

    }
}