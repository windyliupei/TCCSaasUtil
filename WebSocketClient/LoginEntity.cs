using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
     
    public class ClientInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public string phoneUUID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string osType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string osVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string osLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string appVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phoneBrand { get; set; }
    }

    public class LoginEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string applicationID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int isEncrypted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool isAuto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ClientInfo clientInfo { get; set; }
    }
}
