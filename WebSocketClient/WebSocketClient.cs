using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using NATS.Client;
using WebSocketSharp.Net;
using Cookie = System.Net.Cookie;

namespace WebSocketClient
{
    public partial class WebSocketTestClient : Form
    {
        private WebSocket _webSocketClient;
        private LoginResponse _loginResponse;
        private IConnection conn;
        private IAsyncSubscription sAsync = null;

        public WebSocketTestClient()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        } 

        private void btn_Conect_Click(object sender, EventArgs e)
        {
            if (chk_needLogin.Checked)
            {
                if (_loginResponse == null || string.IsNullOrEmpty(_loginResponse.data.sessionId))
                {
                    MessageBox.Show("Please login at first!");
                    return;
                }
            }
            
            MakeConnection();
        }

        private void MakeConnection()
        {
            
            try
            {
                if (_webSocketClient!=null)
	            {
		            _webSocketClient.Close();
	            }
                string port = string.Empty;
                if (num_Port.Value.ToString() != "80")
                {
                    port = ":" + num_Port.Value.ToString();
                }
                
                _webSocketClient = new WebSocket(cmb_wss.SelectedItem.ToString() + txt_wsServer.Text.Trim()+ port + txt_Cmd.Text.Trim());
                //_webSocketClient = new WebSocket("wss://echo.websocket.org");

                if (chk_needLogin.Checked)
                {
                    WebSocketSharp.Net.Cookie cookie =
                        new WebSocketSharp.Net.Cookie("SESSION", _loginResponse.data.sessionId, "/", txt_wsServer.Text);
                        _webSocketClient.SetCookie(cookie);
                }
               

                _webSocketClient.OnClose += _webSocketClient_OnClose;
                _webSocketClient.OnOpen += _webSocketClient_OnOpen;
                _webSocketClient.OnMessage += (sender, e) =>
                {
                    txt_Received.AppendText(string.Format("-----{0}-----",DateTime.Now));
                    txt_Received.AppendText("\r\n");
                    txt_Received.AppendText(e.Data);
                    txt_Received.AppendText("\r\n");
                    txt_Received.AppendText("\r\n");
                };
                _webSocketClient.WaitTime = TimeSpan.FromSeconds(8);

                //_webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Ssl2;
                //_webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Ssl3;
                //_webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls;
                //_webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls11;
                _webSocketClient.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                
                _webSocketClient.Connect();
                //////_webSocketClient.Send("handshake");
                               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void _webSocketClient_OnOpen(object sender, EventArgs e)
        {
            btn_Conect.Enabled = false;
            btn_Disconect.Enabled = true;
        }

        void _webSocketClient_OnClose(object sender, CloseEventArgs e)
        {
            btn_Conect.Enabled = true;
            btn_Disconect.Enabled = false;

            toolStripStatusLabel2.ForeColor = Color.Red;
            toolStripStatusLabel2.Text = "Not login";
            MessageBox.Show($"Connection was broken:{(CloseStatusCode)e.Code} Please re-login");
        }

        private void btn_Disconect_Click(object sender, EventArgs e)
        {
             try
            {
                if (_webSocketClient!=null)
	            {
		            _webSocketClient.Close();
	            }
                btn_Conect.Enabled = true;
                btn_Disconect.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Received.Clear();
            txt_Send.Clear();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (_webSocketClient != null && _webSocketClient.IsAlive)
            {
                _webSocketClient.Send(txt_Send.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please connect web socket server at first!");
            }
        }

        private void btn_login_login_Click(object sender, EventArgs e)
        {
            string schema = cmb_schema.SelectedItem.ToString();
            string host = txt_login_Host.Text;
            int port = (int)num_login_port.Value;
            string uri = txt_login_ReqUrl.Text;
            string url = string.Format("{0}{1}:{2}{3}",schema,host,port,uri);
            string postData = GetPostData();
            
            HttpClientOperation operation = new HttpClientOperation();
            HttpContent content = new StringContent(postData);
            HttpResponseMessage result = operation.SendRequestAsync(HttpMethod.Post, url, content, CancellationToken.None);

            if (result.Content == null)
            {
                MessageBox.Show("WTK!!!!");
                return;
            }

            string loginResult = result.Content.ReadAsStringAsync().Result;
            _loginResponse = JsonConvert.DeserializeObject<LoginResponse>(loginResult);

            if (_loginResponse != null && _loginResponse.errorCode == 0 && _loginResponse.errorMsg == "Success")
            {
                MessageBox.Show($"Login Success, session id:{_loginResponse.data.sessionId}");
                toolStripStatusLabel2.ForeColor = Color.Green;
                toolStripStatusLabel2.Text = $"Login Success, session id:{_loginResponse.data.sessionId}";

                //If re-login please re-connect web socket
                if (_webSocketClient != null)
                {
                    _webSocketClient.OnClose -= _webSocketClient_OnClose;
                    btn_Conect.Enabled = true;
                    btn_Disconect.Enabled = false;
                    _webSocketClient.Close();
                    _webSocketClient.OnClose += _webSocketClient_OnClose;    
                }

                //同步服务器节点信息，一般就是你登录的endpoint
                WsUserLoginRequest request = new WsUserLoginRequest();
                request.IsEncrypted = ((int) this.num_login_isEncrypt.Value);
                request.Password = txt_login_password.Text;
                request.PhoneUuid = txt_phoneUUID.Text;
                request.Username = txt_login_UserName.Text;
                string jsonWsRequest = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                string websocketCommand =
                    $"/ws2/home_saas_ws_node_1?t={jsonWsRequest}";
                txt_Cmd.Text = websocketCommand;

                cmb_wss.SelectedIndex = cmb_schema.SelectedIndex;
                txt_wsServer.Text = txt_login_Host.Text;
                num_Port.Value = num_login_port.Value;

            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

        }
         
        private string GetPostData()
        {
            LoginEntity entity = new LoginEntity();
            entity.applicationID = txt_Application.Text.Trim();
            entity.isEncrypted = (int)num_login_isEncrypt.Value;
            entity.password = txt_login_password.Text.Trim();
            entity.username = txt_login_UserName.Text.Trim();
            entity.isAuto = bool.Parse(cmb_isAuto.SelectedItem.ToString());

            ClientInfo clientInfo = new ClientInfo();
            clientInfo.appVersion = "1.0";
            clientInfo.osLanguage = cmb_language.SelectedItem.ToString();
            clientInfo.osType = "ios";
            clientInfo.osVersion = "1.0";
            clientInfo.phoneBrand = "China Mobile";
            clientInfo.phoneUUID = txt_phoneUUID.Text.Trim();

            entity.clientInfo = clientInfo;

            string entityJson = JsonConvert.SerializeObject(entity);

            return entityJson;
        }

        private void WebSocketClient_Load(object sender, EventArgs e)
        {
            cmb_wss.SelectedIndex = 0;
            cmb_schema.SelectedIndex = 1;
            cmb_HttpMethod.SelectedIndex = 0;
            cmb_ApiAchema.SelectedIndex = 0;
            cmb_language.SelectedIndex = 0;
            txt_Application.Text = Guid.NewGuid().ToString();
            txt_phoneUUID.Text = Guid.NewGuid().ToString();
            cmb_isAuto.SelectedIndex = 1;
            ServicePointManager.ServerCertificateValidationCallback +=
                (obj, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = 
                SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }

        private void saveInputSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveInputWindow sw = new SaveInputWindow(this);
            sw.ShowDialog();
        }

        public InputSetting CreateInputSetting()
        {
            InputSetting input = new InputSetting();

            input.HttpSchema = this.cmb_schema.SelectedItem.ToString();
            input.Login_ApiRul = txt_login_ReqUrl.Text.Trim();
            input.Login_ApplicationId = txt_Application.Text.Trim();
            input.Login_Host = txt_login_Host.Text.Trim();
            input.Login_IsEncrypt = num_login_isEncrypt.Value.ToString();
            input.Login_Password = txt_login_password.Text.Trim();
            input.Login_PhoneUUID = txt_phoneUUID.Text.Trim();
            input.Login_Port = num_login_port.Value.ToString();
            input.Login_UserName = txt_login_UserName.Text.Trim();
            input.Login_Language = cmb_language.SelectedItem.ToString();
            input.IsAuto = bool.Parse(cmb_isAuto.SelectedItem.ToString());

            input.WS_CommdUrl = txt_Cmd.Text.Trim();
            input.WS_Host = txt_wsServer.Text.Trim();
            input.WS_SendedContext = txt_Send.Text.Trim();
            input.WS_Port = num_Port.Value.ToString();

            input.NATS_Host = txt_natHost.Text.Trim();
            input.NATS_Port = num_NasPort.Value.ToString();
            input.NATS_SnededContext = txt_Nas_SendContext.Text.Trim();
            input.NATS_Topic = txt_Nas_Topic.Text;

            return input;
        }

        private void loadInputSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSettingsWindow ls = new LoadSettingsWindow(this);
            ls.ShowDialog();
        }

        public void PutSettings(InputSetting input)
        {
            cmb_schema.SelectedItem = input.HttpSchema;
            txt_login_ReqUrl.Text = input.Login_ApiRul;
            txt_Application.Text = input.Login_ApplicationId;
            txt_login_Host.Text = input.Login_Host;
            num_login_isEncrypt.Value = decimal.Parse(input.Login_IsEncrypt);
            ((Control)num_login_isEncrypt).Text = input.Login_IsEncrypt;
            txt_login_password.Text = input.Login_Password;
            txt_phoneUUID.Text = input.Login_PhoneUUID;
            num_login_port.Value = decimal.Parse(input.Login_Port);
            ((Control)num_login_port).Text = input.Login_Port;
            txt_login_UserName.Text = input.Login_UserName;
            cmb_language.SelectedItem = input.Login_Language;
            cmb_isAuto.SelectedIndex = input.IsAuto ? 0:1;

            txt_Cmd.Text = input.WS_CommdUrl;
            txt_wsServer.Text = input.WS_Host;
            txt_Send.Text = input.WS_SendedContext;    
            num_Port.Value = decimal.Parse(input.WS_Port);
            ((Control)num_Port).Text = input.WS_Port;

            txt_natHost.Text = input.NATS_Host;
            num_NasPort.Value = decimal.Parse(input.NATS_Port);
            ((Control)num_NasPort).Text = input.NATS_Port;
            txt_Nas_SendContext.Text = input.NATS_SnededContext;
            txt_Nas_Topic.Text = input.NATS_Topic;
        }
       
        private void btn_Nas_Connection_Click(object sender, EventArgs e)
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }

            ConnectionFactory cf = new ConnectionFactory();
            
            if (chk_natTls.Checked)
            {
                Options opts = ConnectionFactory.GetDefaultOptions();
                opts.Secure = true;
#if DEBUG
                opts.MaxPingsOut = int.MaxValue;
                opts.Timeout = int.MaxValue;
#endif
                //opts.Servers = new[]
                //    {$"nats://{txt_natHost.Text.Trim()}:{(int) num_NasPort.Value}"};
                opts.Url = $"nats://{txt_natHost.Text.Trim()}:{(int) num_NasPort.Value}";
                opts.TLSRemoteCertificationValidationCallback = TlsRemoteCertificationValidationCallback;
                opts.User = "home";
                opts.Password = "1qaz2wsx";
                

                // .NET requires the private key and cert in the
                //  same file. 'client.pfx' is generated from:
                //
                // openssl pkcs12 -export -out client.pfx -inkey clientkey.pem -in client.pem

               
                X509Certificate2 cert = new X509Certificate2("cert/clientcert.pfx_", "111111");

                //X509Certificate2 rootCert = new X509Certificate2("rootcert.pem", "111111");
                //X509Store store = new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine);
                //store.Open(OpenFlags.ReadWrite);
                //store.Add(rootCert); //where cert is an X509Certificate object
                //store.Close();

                opts.AddCertificate(cert);
                conn = cf.CreateConnection(opts);
            }
            else
            {
                //nats://localhost:4222
                conn = cf.CreateConnection($"nats://{txt_natHost.Text.Trim()}:{(int) num_NasPort.Value}");    
            }
             
            btn_Nas_Connection.Enabled = false;
            btn_Nas_Disconn.Enabled = true;
            btn_Nas_Send.Enabled = true;
            btn_Nas_Sub.Enabled = true;
        }

        private bool TlsRemoteCertificationValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors)
        {
            if (sslpolicyerrors == SslPolicyErrors.None)
                return true;
            return false;

        }


        private void btn_Nas_Disconn_Click(object sender, EventArgs e)
        {
            if (conn != null)
            {
                conn.Close();
                conn.Dispose();
            }
            btn_Nas_Connection.Enabled = true;
            btn_Nas_Disconn.Enabled = false;
            btn_Nas_Send.Enabled = false;
            btn_Nas_Sub.Enabled = false;

            tss_subTopic.Text = "Not Sub any topic";
        }
        private void btn_Nas_Send_Click(object sender, EventArgs e)
        {

            try
            {
                Msg msg = new Msg();
                msg.Data = System.Text.Encoding.Default.GetBytes(txt_Nas_SendContext.Text);
                msg.Subject = txt_Nas_Topic.Text.Trim();

                conn.Publish(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Nas_Sub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nas_Topic.Text.Trim()))
            {
                MessageBox.Show("What are you want to subscript???");
                return;
            }

                       
            sAsync = conn.SubscribeAsync(txt_Nas_Topic.Text.Trim());
            
            sAsync.MessageHandler += (nat_Sender, nat_e) =>
            {
                txt_Nas_received.AppendText(string.Format("-----Received at:{0}-----", DateTime.Now));
                txt_Nas_received.AppendText("\r\n");
                txt_Nas_received.AppendText(System.Text.Encoding.Default.GetString(nat_e.Message.Data));
                txt_Nas_received.AppendText("\r\n");
                txt_Nas_received.AppendText("\r\n");
            };
            sAsync.Start();

            tss_subTopic.Text = txt_Nas_Topic.Text.Trim();
        }

        private void btn_SendApi_Click(object sender, EventArgs e)
        {
            if (_loginResponse == null || string.IsNullOrEmpty(_loginResponse.data.sessionId))
            {
                MessageBox.Show("Please login at first!");
                return;
            }

            string schema = cmb_ApiAchema.SelectedItem.ToString();
            string host = txt_ApiHost.Text;
            int port = (int)num_ApiPort.Value;
            string uri = txt_ApiAction.Text;
            string url = string.Format("{0}{1}:{2}{3}", schema, host, port, uri);
             

            HttpMethod httpMethod = HttpMethod.Post;
            string selectedHttpMethod = cmb_HttpMethod.SelectedItem.ToString();

            switch (selectedHttpMethod)
            {
                case "POST":
                {
                    httpMethod = HttpMethod.Post;
                    break;
                }
                case "GET":
                {
                    httpMethod = HttpMethod.Get;
                    break;
                }
                case "DELETE":
                {
                    httpMethod = HttpMethod.Delete;
                    break;
                }
                case "PUT":
                {
                    httpMethod = HttpMethod.Post;
                    break;
                }
                default:
                    httpMethod = HttpMethod.Post;
                    break;
            }

            HttpClientOperation operation = new HttpClientOperation();
            HttpContent content = new StringContent(txt_ApiSend.Text);

            //Set hearders
            Dictionary<string,string> hearder = new Dictionary<string, string>();
            
            
            //
            List<Cookie> cookies = new List<Cookie>();
            //Cookie cookie = new Cookie("SESSIONID",_loginResponse.data.sessionId,"/",txt_ApiHost.Text);
            Cookie cookie = new Cookie("SESSION", _loginResponse.data.sessionId, "/", txt_ApiHost.Text);
            cookies.Add(cookie);

            HttpResponseMessage result = operation.SendRequestAsync(httpMethod, url, content, CancellationToken.None, "application/json", hearder, cookies);

            if (result.Content == null)
            {
                MessageBox.Show("WTK!!!!");
                return;
            }

            string httpResponse = result.Content.ReadAsStringAsync().Result;

            txt_ApiReceive.Text = httpResponse;
            
        }


        
    }

}
