using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections;
using Media;


namespace VK_MUSIC_APP
{
    public partial class Form1 : Form
    {
        #region Fields
        private Player pl = new Player();
        private string sVK_ID = "";
        private string sACCESS_TOKEN = "";
        private string sFolderLib = "";
        WorkFiles builder = new WorkFiles("config.txt");
        private Hashtable[] htCollect_Audio;
        private int move_music_list = 0;
        private NetworkApiVK lib_api;
        private int time_Passed = 0; // времени прошло с начала трека
        int minute = 0;
        int seconds = 0;
        int minute_pa = 0;
        int secon_pa = 0;
        #endregion
        public Form1()
        {
            PreInitializeComponent();
            InitializeComponent();
            start_program();
            lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();
            lab_TimePassed.Text = "0";
            create_time_remain();

        }

        private void create_time_remain()
        {
            minute = 0;
            int time_remain = Convert.ToInt32(htCollect_Audio[move_music_list]["duration"]);
            for (int i = 0; i < time_remain; i++)
            {
                if (time_remain > 60)
                    minute++;
                else
                { break; }
                time_remain -= 60;
            }
            minute *= -1;
            seconds = time_remain;
            lab_TimeRemain.Text = minute.ToString() + "." + time_remain;
        }

        private void PreInitializeComponent()
        {
            string something;
            var data_file = builder.read_file();
            sVK_ID = data_file["uid"];
            sACCESS_TOKEN = data_file["token"];
            if (data_file.TryGetValue("library", out something) == true)
                sFolderLib = data_file["library"];
            lib_api = new NetworkApiVK(sVK_ID, sACCESS_TOKEN);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_program()
        {
            htCollect_Audio = XML_PARSE(lib_api.audio_get());
            string url_music = htCollect_Audio[move_music_list]["url"].ToString();
            ProgressBar1.Maximum = Convert.ToInt32(htCollect_Audio[move_music_list]["duration"]);
            pl.Open(url_music);
        }


        public Hashtable[] XML_PARSE(String XML_DATA)
        {
            XmlReader reader = XmlReader.Create(new StringReader(XML_DATA));
            //List<Hashtable> lAudioUser = new List<Hashtable>();
            int i = 0;
            string sTemp = "";
            // Create an XmlReader
            reader.ReadToFollowing("count");
            reader.Read();
            Hashtable[] dict_audio = new Hashtable[Convert.ToInt32(reader.Value)];
            lab_CountAudio.Text = Convert.ToString(reader.Value);
            reader.ReadToFollowing("photo");
            reader.Read();
            AvatarUser.LoadAsync(reader.Value);
            reader.ReadToFollowing("name");
            reader.Read();
            lab_NameUser.Text = reader.Value;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        sTemp = reader.Name;
                        break;
                    case XmlNodeType.Text:
                        if (sTemp != "id" && sTemp != "owner_id")
                        {
                            if (dict_audio[i] == null)
                                dict_audio[i] = new Hashtable();
                            dict_audio[i].Add(sTemp, reader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.Name == "audio")
                        {
                            i++;
                        }
                        break;
                }
            }
            return dict_audio;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (pl.IsPaused() == true) //
            {
                pl.Play(true);
                timer1.Start();
            }
            else
            {
                pl.Pause();
                timer1.Stop();
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            next_song();
        }

        private void next_song()
        {
            time_Passed = 0; //обнуляем счетчик времени 
            minute_pa = 0;
            secon_pa = 0;
            timer1.Start();

            if (move_music_list < htCollect_Audio.Length) { move_music_list++; };
            if (pl.IsOpen() == true)
                pl.Close();
            if (pl.IsOpen() == false)
            {
                pl.Close();
                create_time_remain();
                pl.Open(htCollect_Audio[move_music_list]["url"].ToString());
                ProgressBar1.Maximum = Convert.ToInt32(htCollect_Audio[move_music_list]["duration"]);
                lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();
                pl.Play(false);
            }
        }


        private void picBox_buttonPrev_Click(object sender, EventArgs e)
        {

            time_Passed = 0;
            minute_pa = 0;
            secon_pa = 0;
            timer1.Start();

            if (move_music_list > 0) move_music_list--;
            if (pl.IsOpen() == true)
                pl.Close();
            if (pl.IsOpen() == false)
            {
                pl.Close();
                create_time_remain();
                pl.Open(htCollect_Audio[move_music_list]["url"].ToString());
                ProgressBar1.Maximum = Convert.ToInt32(htCollect_Audio[move_music_list]["duration"]);
                lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();
                pl.Play(false);
            }
        }

        private void lIBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folder_LIB_MUSIC.ShowDialog();
            builder.write_data_file(new Dictionary<string, string>() { { "library", folder_LIB_MUSIC.SelectedPath } });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_Passed++;
            if (ProgressBar1.Value < ProgressBar1.Maximum)
            {
                forming_time_remain();
                forming_time_passed();
                ProgressBar1.Value = time_Passed;
            }
            else
                next_song();
        }
        private void forming_time_remain()
        {
            if (seconds != 0)
                seconds--;
            else
            {
                minute++;
                seconds = 59;
            }
            lab_TimeRemain.Text = minute.ToString() + "." + seconds.ToString();
        }
        private void forming_time_passed()
        {
            secon_pa++;
            if (secon_pa == 60)
            {
                minute_pa++;
                secon_pa = 0;
            }
            lab_TimePassed.Text = minute_pa.ToString() + "." + secon_pa.ToString();
        }
    }
}
