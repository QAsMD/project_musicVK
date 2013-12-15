using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VK_MUSIC_APP
{
    class WorkFiles
    {
        private string path_file = "";
        private IDictionary <string, string> parametrs_program = new Dictionary<string, string>();
        public WorkFiles(string path)
        {
            path_file = path.ToString();
        }

        public IDictionary<string,string> read_file()
        {
            if (File.Exists(path_file) == true)
            {
                StreamReader stream_read = new StreamReader(path_file);
                string data_output = stream_read.ReadLine();
                var data_process = data_output.Split(':');
                parametrs_program.Add("uid", data_process[1]);
                data_output = stream_read.ReadLine();
                data_process = data_output.Split(':');
                parametrs_program.Add("token", data_process[1]);
                //parametrs_program.Add("id_user", id_user);
                //parametrs_program.Add("token", token);
                //parametrs_program.Add("lib_music", library);
            }
            else
            {
                MessageBox.Show("Похоже вы удалили конфигурационный файл или он отсутсвует.\nНачинаю процесс восстановления.");
                SetUpMusic new_config = new SetUpMusic();
                new_config.ShowDialog();
                read_file();
            }
            return parametrs_program;
        }

        public void write_data_file(IDictionary<string, string> info_parameter)
        {
            StreamWriter WriteData = new StreamWriter("config.txt");
            foreach (string key in info_parameter.Keys)
            {
                WriteData.Write(key + ":" + info_parameter[key] + "\n");
            }
            WriteData.Close();
        }
    }
}
