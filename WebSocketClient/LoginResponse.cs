using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketClient
{
    public class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int userID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string countryCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int isActivated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int userType { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public string sessionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserInfo userInfo { get; set; }
    }

    public class LoginResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int errorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string errorMsg { get; set; }
    }
}
