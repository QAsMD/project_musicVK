using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace VK_MUSIC_APP
{
    public partial class FormPlaylist : Form
    {
        public FormPlaylist(Hashtable[] Playlist)
        {
            InitializeComponent();
            add_element(Playlist);
        }

        private void add_element(Hashtable[] Playlist)
        {
            foreach (var data in Playlist)
            {
                if (data != null)
                {
                    string duration_song = remain_time(Convert.ToInt32(data["duration"]));
                    string sElement = data["artist"].ToString() + " - " + data["title"].ToString() + "  " + duration_song;
                    listBox_Playlist.Items.Add(sElement);
                }
            }
        }
        private string remain_time(int time_song)
        {
            int minute = 0;
            int seconds = 0;
            for (int i = 0; i < time_song; i++)
            {
                if (time_song > 60)
                    minute++;
                else
                { break; }
                time_song -= 60;
            }
            seconds = time_song;
            return minute.ToString() + "." + seconds.ToString();
        }
        private void listBox_Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
