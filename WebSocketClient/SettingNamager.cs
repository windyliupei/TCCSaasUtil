using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
    public class SettingNamager
    {
        private static SettingNamager _manager;
        private static Dictionary<string, InputSetting> _settingsDict = new Dictionary<string,InputSetting>();
        private static string currentPath = System.AppDomain.CurrentDomain.BaseDirectory+"settings.json";

        private SettingNamager()
        {
            ReadSettings();
        }

        public static SettingNamager Instance
        {
            get 
            {
                if (_manager == null)
                {
                    _manager = new SettingNamager();
                }
                return _manager;
            }
        }

        public Dictionary<string, InputSetting> GetSettingList()
        {
            return _settingsDict;
        }

        public static void WirteSettings()
        {
            if (!File.Exists(currentPath))
            {
                FileStream stream = File.Create(currentPath);
                stream.Close();
            }

            using (StreamWriter sw = new StreamWriter(currentPath)) 
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                //构建Json.net的写入流  
                JsonWriter writer = new JsonTextWriter(sw);
                //把模型数据序列化并写入Json.net的JsonWriter流中  
                serializer.Serialize(writer, _settingsDict.Values.ToList());
                //ser.Serialize(writer, ht);  
                writer.Close();
                sw.Close();  
            }
        }

        public static void ReadSettings()
        {
            if (!File.Exists(currentPath))
            {
                return;
            }

            using (StreamReader sr = new StreamReader(currentPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                //构建Json.net的读取流  
                JsonReader reader = new JsonTextReader(sr);
                //对读取出的Json.net的reader流进行反序列化，并装载到模型中  
                List<InputSetting> settingList = serializer.Deserialize<List<InputSetting>>(reader);

                if (settingList != null)
                {
                    _settingsDict.Clear();
                    foreach (var item in settingList)
                    {
                        _settingsDict.Add(item.Name, item);
                    }
                }
            }
        }
         
    }
}
