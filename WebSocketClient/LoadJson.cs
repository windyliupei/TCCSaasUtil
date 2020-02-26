using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace WebSocketClient
{
    public class LoadJsonService
    {
        public static string LoadJson(String filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Boolean filePathValid = File.Exists(filePath)
                && fileInfo.Extension.EndsWith("json");

            if (filePathValid) {
                return File.ReadAllText(filePath);
            }
            
            return String.Empty;
        }
    }
}
