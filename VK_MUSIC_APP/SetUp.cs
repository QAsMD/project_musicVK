using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VK_MUSIC_APP
{
    public partial class SetUpMusic : Form
    {
        public SetUpMusic()
        {
            InitializeComponent();
        }

        private void but_Auth_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://oauth.vk.com/authorize?client_id=3817510&scope=offline,audio&redirect_uri=https://oauth.vk.com/blank.html &display=popup&v=5.2&response_type=token");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ( text_AccessToken.Text != null && text_IdUser.Text != null )
            {
                try
                {
                    int var_id_user = Convert.ToInt32(text_IdUser.Text);
                    record_config();
                    this.Close();
                }
                catch //asd
                { MessageBox.Show("Поле ID_User должен состоять из цифр"); }
            }
            else
            { MessageBox.Show("Проверьте правильность ввода"); }
        }

        private void record_config()
        {
            StreamWriter WriteData = new StreamWriter("config.txt");
            WriteData.Write("Uid_User:" + text_IdUser.Text + "\n");
            WriteData.Write("Access_Token:" + text_AccessToken.Text + "\n");
            WriteData.Close();
        }
    }
}
