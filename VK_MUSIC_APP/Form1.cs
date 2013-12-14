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
        //private string sSize_Cache = "";
        private string sVK_ID = "";
        private string sACCESS_TOKEN = "";
        //private string sFolderLib = "";
        private Hashtable[] htCollect_Audio;
        private int move_music_list = 0;
        private NetworkApiVK lib_api;
        private bool bPlay = false;
#endregion
        public Form1()
        {
            PreInitializeComponent();
            InitializeComponent();
            start_program();
            lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();

        }

        private void PreInitializeComponent()
        {
            if (File.Exists("config.txt") == true)
            {
                read_config();
            }
            else
            {
                SetUpMusic setProgram = new SetUpMusic();
                setProgram.ShowDialog();
                read_config();
            }
        }

        private void read_config()
        {
            StreamReader read_config = new StreamReader("config.txt");
            var read_data = read_config.ReadLine();
            sVK_ID = read_data.Split(':')[1];
            read_data = read_config.ReadLine();
            sACCESS_TOKEN = read_data.Split(':')[1];
            read_config.Close();
            lib_api = new NetworkApiVK(sVK_ID, sACCESS_TOKEN);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings fSettings = new Settings();
            fSettings.ShowDialog();
        }

        private void start_program()
        {
            htCollect_Audio = XML_PARSE(lib_api.audio_get());
            string url_music = htCollect_Audio[move_music_list]["url"].ToString();
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
            if (this.bPlay)
            {
                pl.Pause();
                bPlay = false;
            }
            else
            { 
                pl.Play(true);
                bPlay = true;
            }
              
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            move_music_list++;
            pl.Close();
            pl.Open(htCollect_Audio[move_music_list]["url"].ToString());
            lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();
            pl.Play(false);
        }

        private void picBox_buttonPrev_Click(object sender, EventArgs e)
        {
            if ( move_music_list > 0 ) move_music_list--;
           
            pl.Close();
            pl.Open(htCollect_Audio[move_music_list]["url"].ToString());
            lab_infoSong.Text = "Artist: " + htCollect_Audio[move_music_list]["artist"].ToString() + "\nSong: " + htCollect_Audio[move_music_list]["title"].ToString();
            pl.Play(false);
        }
    }
}
