using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebSocketClient
{
    public class WsUserLoginRequest
    {
        [JsonProperty("phoneUUID")]
        public string PhoneUuid
        {
            get { return phoneUUID; }
            set { phoneUUID = value; }
        }

        [JsonProperty("isEncrypted")]
        public int IsEncrypted
        {
            get { return isEncrypted; }
            set { isEncrypted = value; }
        }

        [JsonProperty("password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [JsonProperty("username")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        String phoneUUID;
        int isEncrypted;
        String password;
        String username;
    }
}
