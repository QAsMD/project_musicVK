namespace VK_MUSIC_APP
{
    partial class SetUpMusic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetUpMusic));
            this.lab_Welcome = new System.Windows.Forms.Label();
            this.ric_TextBoxInstruct = new System.Windows.Forms.RichTextBox();
            this.lab_ID_User = new System.Windows.Forms.Label();
            this.lab_Access_Token = new System.Windows.Forms.Label();
            this.text_AccessToken = new System.Windows.Forms.TextBox();
            this.text_IdUser = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.but_Auth = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Welcome
            // 
            this.lab_Welcome.Location = new System.Drawing.Point(12, 9);
            this.lab_Welcome.Name = "lab_Welcome";
            this.lab_Welcome.Size = new System.Drawing.Size(510, 18);
            this.lab_Welcome.TabIndex = 0;
            this.lab_Welcome.Text = "Добро пожаловать!";
            this.lab_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ric_TextBoxInstruct
            // 
            this.ric_TextBoxInstruct.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ric_TextBoxInstruct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ric_TextBoxInstruct.Cursor = System.Windows.Forms.Cursors.Default;
            this.ric_TextBoxInstruct.Location = new System.Drawing.Point(12, 30);
            this.ric_TextBoxInstruct.Name = "ric_TextBoxInstruct";
            this.ric_TextBoxInstruct.Size = new System.Drawing.Size(510, 62);
            this.ric_TextBoxInstruct.TabIndex = 1;
            this.ric_TextBoxInstruct.Text = resources.GetString("ric_TextBoxInstruct.Text");
            // 
            // lab_ID_User
            // 
            this.lab_ID_User.AutoSize = true;
            this.lab_ID_User.Location = new System.Drawing.Point(195, 145);
            this.lab_ID_User.Name = "lab_ID_User";
            this.lab_ID_User.Size = new System.Drawing.Size(46, 13);
            this.lab_ID_User.TabIndex = 4;
            this.lab_ID_User.Text = "ID_User";
            // 
            // lab_Access_Token
            // 
            this.lab_Access_Token.AutoSize = true;
            this.lab_Access_Token.Location = new System.Drawing.Point(179, 172);
            this.lab_Access_Token.Name = "lab_Access_Token";
            this.lab_Access_Token.Size = new System.Drawing.Size(79, 13);
            this.lab_Access_Token.TabIndex = 5;
            this.lab_Access_Token.Text = "Access_Token";
            // 
            // text_AccessToken
            // 
            this.text_AccessToken.Location = new System.Drawing.Point(264, 169);
            this.text_AccessToken.Name = "text_AccessToken";
            this.text_AccessToken.Size = new System.Drawing.Size(258, 20);
            this.text_AccessToken.TabIndex = 6;
            // 
            // text_IdUser
            // 
            this.text_IdUser.Location = new System.Drawing.Point(264, 142);
            this.text_IdUser.Name = "text_IdUser";
            this.text_IdUser.Size = new System.Drawing.Size(258, 20);
            this.text_IdUser.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(216, 204);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 36);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(376, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 36);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // but_Auth
            // 
            this.but_Auth.Location = new System.Drawing.Point(264, 98);
            this.but_Auth.Name = "but_Auth";
            this.but_Auth.Size = new System.Drawing.Size(170, 32);
            this.but_Auth.TabIndex = 10;
            this.but_Auth.Text = "Authorization";
            this.but_Auth.UseVisualStyleBackColor = true;
            this.but_Auth.Click += new System.EventHandler(this.but_Auth_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "instruct1.bmp");
            this.imageList1.Images.SetKeyName(1, "instruct2.bmp");
            this.imageList1.Images.SetKeyName(2, "instruct3.bmp");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SetUpMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_Auth);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.text_IdUser);
            this.Controls.Add(this.text_AccessToken);
            this.Controls.Add(this.lab_Access_Token);
            this.Controls.Add(this.lab_ID_User);
            this.Controls.Add(this.ric_TextBoxInstruct);
            this.Controls.Add(this.lab_Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetUpMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup Music VK";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Welcome;
        private System.Windows.Forms.RichTextBox ric_TextBoxInstruct;
        private System.Windows.Forms.Label lab_ID_User;
        private System.Windows.Forms.Label lab_Access_Token;
        private System.Windows.Forms.TextBox text_AccessToken;
        private System.Windows.Forms.TextBox text_IdUser;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button but_Auth;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}