using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
    public class InputSetting
    {
        public string Name { get; set; }

        public string HttpSchema { get; set; }
        public string Login_Host { get; set; }
        public string Login_Port { get; set; }
        public string Login_ApiRul { get; set; }
        public string Login_UserName { get; set; }
        public string Login_Password { get; set; }
        public string Login_IsEncrypt { get; set; }
        public string Login_ApplicationId { get; set; }
        public string Login_PhoneUUID { get; set; }
        public string Login_Language { get; set; }
        public bool IsAuto { get; set; }

        public string WS_Host { get; set; }
        public string WS_Port { get; set; }
        public string WS_CommdUrl { get; set; }
        public string WS_SendedContext { get; set; }

        public string NATS_Host { get; set; }
        public string NATS_Port { get; set; }
        public string NATS_SnededContext { get; set; }
        public string NATS_Topic { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
