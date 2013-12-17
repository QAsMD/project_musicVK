using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;

namespace VK_MUSIC_APP
{
    class NetworkApiVK
    {
        IDictionary<string, string> ht_API_METHODS = new Dictionary<string, string>();
        public NetworkApiVK(string id_user, string access_token)
        {
            //url базис для формирования запроса получения музыки
            string temp_url = "https://api.vk.com/method/audio.get.xml?owner_id=%uid_user&need_user=1&v=5.2&access_token=%token";
            temp_url = temp_url.Replace("%uid_user", id_user);
            temp_url = temp_url.Replace("%token", access_token);
            ht_API_METHODS.Add("audio.get", temp_url);
            //url базис для формирования запроса получения информации о пользовател
            temp_url = "https://api.vk.com/method/users.get.xml?&fields=photo_200&uid=%uid_user";
            temp_url = temp_url.Replace("%uid_user", id_user);
            ht_API_METHODS.Add("users.get", temp_url);
        }
        public string audio_get()
        {
            var data_audio = GetMethod(ht_API_METHODS["audio.get"]);
            return data_audio;
        }

        public string user_get()
        {
            var data_user = GetMethod(ht_API_METHODS["users.get"]);
            var avatar = XML_PARSE(data_user);
            return avatar;
        }
        private string GetMethod(string postUrl)
        {
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(postUrl);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            String sLine = objReader.ReadToEnd();
            return sLine;
        }

        private string XML_PARSE(String XML_DATA)
        {
            XmlReader reader = XmlReader.Create(new StringReader(XML_DATA));
            reader.ReadToFollowing("photo_200");
            reader.Read();
            return reader.Value;
        }
    }
}
