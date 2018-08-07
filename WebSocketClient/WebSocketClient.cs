using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Exceptions;
using MQTTnet.Protocol;

namespace WebSocketClient
{
    public partial class WebSocketTestClient : Form
    {
        private WebSocket _webSocketClient;
        private LoginResponse _loginResponse;
        private IConnection conn;
        private IAsyncSubscription sAsync = null;
        private FileStream _webSocketLogFileStream;
        private string _webSocketLogFilePath;
        private FileStream _webApiLogFileStream;
        private string _webApiLogFilePath;
        private IMqttClient mqttClient;
        private char ctrl_a = '\u0001';

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
                    txt_Received.AppendText($"------{DateTime.Now}-----");
                    //txt_Received.AppendText("\r\n");
                    txt_Received.AppendText(e.Data);
                    txt_Received.AppendText("\r\n");
                    //txt_Received.AppendText("\r\n");
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
            //txt_Send.Clear();
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

            //After V2 we need to request 'http://localhost:8082/v1/api/user/encryptInfo'
            //at first.

            string encryptReq = "{\"username\":\""+txt_login_UserName.Text+"\",\"applicationID\":\"237b42b-0ce7-4582-830c-34d930b1fd52\"}";
            HttpContent encryptContent = new StringContent(encryptReq);
            string encryUrl = string.Format("{0}{1}:{2}{3}", schema, host, port, "/v1/api/user/encryptInfo");
            HttpClientOperationAsync encryOperation = new HttpClientOperationAsync(encryUrl, encryptContent);
            Task<HttpResponseMessage> encrtyTask = encryOperation.PostAsync();
            var encryQueryResult = encrtyTask.Result;


            HttpContent content = new StringContent(postData);
            HttpClientOperationAsync operation = new HttpClientOperationAsync(url, content);
            Task<HttpResponseMessage> task = operation.PostAsync();
            if (task.Result.Content == null)
            {
                MessageBox.Show("WTF!!!!");
                return;
            }

            string loginResult = task.Result.Content.ReadAsStringAsync().Result;
            _loginResponse = JsonConvert.DeserializeObject<LoginResponse>(loginResult);

            if (_loginResponse != null && _loginResponse.errorCode == 0 && _loginResponse.data.sessionId.Length>1)
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
                string websocketCommand = string.Empty;
                string jsonWsRequest = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                if (_loginResponse.data.wsUrl.Length > 0)
                {
                    websocketCommand =
                        $"{_loginResponse.data.wsUrl.First()}?t={jsonWsRequest}";    
                }
                else
                {
                    websocketCommand =
                        $"{"/v1/websocket"}?t={jsonWsRequest}";
                }
                
                txt_Cmd.Text = websocketCommand;

                cmb_wss.SelectedIndex = cmb_schema.SelectedIndex;
                txt_wsServer.Text = txt_login_Host.Text;
                num_Port.Value = num_login_port.Value+1;

                cmb_ApiAchema.SelectedIndex = cmb_schema.SelectedIndex;
                txt_ApiHost.Text = txt_login_Host.Text;
                num_ApiPort.Value = num_login_port.Value;

                //创建web socket Log 文件
                string currentExecutePath = System.Environment.CurrentDirectory;
                if (!Directory.Exists(currentExecutePath + "\\" + "log"))
                {
                    Directory.CreateDirectory(currentExecutePath + "\\" + "log");
                }

                string webSocketLogfileName = System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
                _webSocketLogFilePath = string.Format($"{currentExecutePath}\\log\\webSocket_{webSocketLogfileName}.log");

                if (_webSocketLogFileStream!=null &&!_webSocketLogFileStream.Name.Equals(_webSocketLogFilePath))
                {
                    _webSocketLogFileStream.Close();
                }

                _webSocketLogFileStream = File.Create(_webSocketLogFilePath);
                _webSocketLogFileStream.Close();

                //创建web api Log 文件
                string webApiLogFileName = System.DateTime.Now.ToString("webApi_yyyy_MM_dd_HH_mm_ss");
                _webApiLogFilePath = string.Format($"{currentExecutePath}\\log\\{webApiLogFileName}.log");

                if (_webApiLogFileStream != null && !_webApiLogFileStream.Name.Equals(_webApiLogFilePath))
                {
                    _webApiLogFileStream.Close();
                }

                _webApiLogFileStream = File.Create(_webApiLogFilePath);
                _webApiLogFileStream.Close();
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

            //
            this.txt_Send.MaxLength             = Int32.MaxValue;
            this.txt_Received.MaxLength         = Int32.MaxValue;
            this.txt_Nas_SendContext.MaxLength  = Int32.MaxValue;
            this.txt_Nas_received.MaxLength     = Int32.MaxValue;
            this.txt_ApiSend.MaxLength          = Int32.MaxValue;
            this.txt_ApiReceive.MaxLength       = Int32.MaxValue;
            this.txt_mqttSentContent.MaxLength  = Int32.MaxValue;
            this.txt_mqttReceiveContent.MaxLength = Int32.MaxValue;

            this.txt_Send.KeyPress += this.txt_KeyPress;
            this.txt_Received.KeyPress += this.txt_KeyPress;
            this.txt_Nas_SendContext.KeyPress += this.txt_KeyPress;
            this.txt_Nas_received.KeyPress += this.txt_KeyPress;
            this.txt_ApiSend.KeyPress += this.txt_KeyPress;
            this.txt_ApiReceive.KeyPress += this.txt_KeyPress;
            this.txt_mqttSentContent.KeyPress += this.txt_KeyPress;
            this.txt_mqttReceiveContent.KeyPress += this.txt_KeyPress;


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
                X509Certificate2 cert = new X509Certificate2("cert/dotntClientcert.pfx_", "111111");
                
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

            string topic = txt_Nas_Topic.Text.Trim();
            //string group = "balance";
            //sAsync = conn.SubscribeAsync(topic, group);
            sAsync = conn.SubscribeAsync(topic);

            sAsync.MessageHandler += (nat_Sender, nat_e) =>
            {
                txt_Nas_received.AppendText(string.Format("-----Received at:{0}-----", DateTime.Now));
                //txt_Nas_received.AppendText("\r\n");
                txt_Nas_received.AppendText(System.Text.Encoding.Default.GetString(nat_e.Message.Data));
                //txt_Nas_received.AppendText("\r\n");
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

            HttpContent content = new StringContent(txt_ApiSend.Text);

            //Set hearders
            Dictionary<string, string> hearders = new Dictionary<string, string>();

            List<Cookie> cookies = new List<Cookie>();
            Cookie cookie = new Cookie("SESSION", _loginResponse.data.sessionId, "/", txt_ApiHost.Text);
            cookies.Add(cookie);

            HttpClientOperationAsync operationAsync = new HttpClientOperationAsync(url, content, hearders, cookies);
            string selectedHttpMethod = cmb_HttpMethod.SelectedItem.ToString();
            Task<HttpResponseMessage> task = null;
            switch (selectedHttpMethod)
            {
                case "POST":
                {
                    task =operationAsync.PostAsync();
                    break;
                }
                case "GET":
                {
                    task = operationAsync.GetAsync();
                    break;
                }
                case "DELETE":
                {
                    task = operationAsync.DeleteAsync();
                    break;
                }
                case "PUT":
                {
                    task = operationAsync.PutAsync(); 
                    break;
                }
                default:
                     
                    break;
            }

            if (task != null && task.Result.Content == null)
            {
                MessageBox.Show("WTK!!!!");
                return;
            }

            if (task != null)
            {
                string httpResponse = task.Result.Content.ReadAsStringAsync().Result;

                txt_ApiReceive.Text = httpResponse;
            }
        }

        

        private void btn_SaveLog_Click(object sender, EventArgs e)
        {
           _webSocketLogFileStream = File.OpenWrite(_webSocketLogFilePath);
           _webSocketLogFileStream.Position = _webSocketLogFileStream.Length;

           Dictionary<string, object> deserializeObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, Object>>(txt_Send.Text);
           string msgType = string.Empty;
           if (deserializeObject.TryGetValue("msgType", out Object msgTypeValue))
           {
               msgType = msgTypeValue.ToString();
           }
            //写入文件
            Encoding encoder = Encoding.UTF8;

            byte[] spliteBytes = encoder.GetBytes($"====================================================================\r\n");
            _webSocketLogFileStream.Write(spliteBytes, 0, spliteBytes.Length);

            byte[] requestHeader = encoder.GetBytes($"------{DateTime.Now}------Web Socket Rrequest: {msgType}\r\n");
            byte[] requestBody    = encoder.GetBytes($"{txt_Send.Text}\r\n");

            _webSocketLogFileStream.Write(requestHeader, 0, requestHeader.Length);
            _webSocketLogFileStream.Write(requestBody, 0, requestBody.Length);

            byte[] spliteResponseBytes = encoder.GetBytes($"-------------------------------------------------\r\n");
            _webSocketLogFileStream.Write(spliteResponseBytes, 0, spliteResponseBytes.Length);

            byte[] responseHeader = encoder.GetBytes($"------{DateTime.Now}------Web Socket response: {msgType}\r\n");
            byte[] responseBody = encoder.GetBytes($"{txt_Received.Text}\r\n");

            _webSocketLogFileStream.Write(responseHeader, 0, responseHeader.Length);
            _webSocketLogFileStream.Write(responseBody, 0, responseBody.Length);

            _webSocketLogFileStream.Write(spliteResponseBytes, 0, spliteResponseBytes.Length);

            byte[] toNatsHeader = encoder.GetBytes($"------{DateTime.Now}------Web Socket to Nas Request: {msgType}\r\n");
            byte[] toNasBody = encoder.GetBytes($"{txt_Nas_received.Text}\r\n");

            _webSocketLogFileStream.Write(toNatsHeader, 0, toNatsHeader.Length);
            _webSocketLogFileStream.Write(toNasBody, 0, toNasBody.Length);

            _webSocketLogFileStream.Close();
        }

        private void btn_saveApiLog_Click(object sender, EventArgs e)
        {
            _webApiLogFileStream = File.OpenWrite(_webApiLogFilePath);
            _webApiLogFileStream.Position = _webApiLogFileStream.Length;

            
            string msgType = txt_ApiAction.Text;
             
            //写入文件
            Encoding encoder = Encoding.UTF8;

            byte[] spliteBytes = encoder.GetBytes($"====================================================================\r\n");
            _webApiLogFileStream.Write(spliteBytes,0,spliteBytes.Length);

            byte[] requestHeader = encoder.GetBytes($"------{DateTime.Now}------Web Api Rrequest: {msgType}\r\n");
            byte[] requestBody = encoder.GetBytes($"{txt_ApiSend.Text}\r\n");

            _webApiLogFileStream.Write(requestHeader, 0, requestHeader.Length);
            _webApiLogFileStream.Write(requestBody, 0, requestBody.Length);

            byte[] spliteResponseBytes = encoder.GetBytes($"-------------------------------------------------\r\n");
            _webApiLogFileStream.Write(spliteResponseBytes,0,spliteResponseBytes.Length);

            byte[] responseHeader = encoder.GetBytes($"------{DateTime.Now}------Web Api response: {msgType}\r\n");
            byte[] responseBody = encoder.GetBytes($"{txt_ApiReceive.Text}\r\n");

            _webApiLogFileStream.Write(responseHeader, 0, responseHeader.Length);
            _webApiLogFileStream.Write(responseBody, 0, responseBody.Length);

            _webApiLogFileStream.Close();
        }

        private void btnMqttConnect_Click(object sender, EventArgs e)
        {
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            mqttClient.Connected += MqttClient_Connected;
            mqttClient.ApplicationMessageReceived += MqttClient_ApplicationMessageReceived;
            mqttClient.Disconnected += MqttClient_Disconnected;



            string mqttServerAddress = txt_mqttService.Text;
            int mqttPort = int.Parse(num_mqttPort.Value.ToString());

            var connectOption = 
            new MqttClientOptionsBuilder()
            .WithTcpServer(mqttServerAddress, mqttPort)
            .WithClientId("Client_Tool_"+ Guid.NewGuid().ToString())
            .WithKeepAlivePeriod(TimeSpan.FromHours(24))
            .WithCleanSession(false)
            .Build();

            var connectTask = mqttClient.ConnectAsync(connectOption);
            connectTask.ContinueWith(t => {
                this.btn_mqttConnect.Enabled = false;
                this.btn_DisconnectMqtt.Enabled = true;
                this.btn_MqttPub.Enabled = true;
                this.btn_MqttSub.Enabled = true;
            });


        }

        private void MqttClient_Disconnected(object sender, MqttClientDisconnectedEventArgs e)
        {
            MessageBox.Show("Disconnect");
        }

        private void MqttClient_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
        {
            txt_mqttReceiveContent.Text = e.ApplicationMessage.ConvertPayloadToString();
        }

        private void MqttClient_Connected(object sender, MqttClientConnectedEventArgs e)
        {
            MessageBox.Show("Connected");
        }

        private void btn_DisconnectMqtt_Click(object sender, EventArgs e)
        {
            if (mqttClient != null)
            {
                if (mqttClient.IsConnected)
                {
                    mqttClient.DisconnectAsync().ContinueWith(t => {
                        this.btn_mqttConnect.Enabled = true;
                        this.btn_MqttPub.Enabled = false;
                        this.btn_MqttSub.Enabled = false;
                        this.btn_DisconnectMqtt.Enabled = false;
                    });
                }
                else
                {
                    this.btn_mqttConnect.Enabled = true;
                    this.btn_MqttPub.Enabled = false;
                    this.btn_MqttSub.Enabled = false;
                    this.btn_DisconnectMqtt.Enabled = false;
                }
                lbl_SubTopic.Text = string.Empty;
            }
        }

        private void btnMqttSub_Click(object sender, EventArgs e)
        {
            if (mqttClient != null && mqttClient.IsConnected)
            {
                mqttClient.SubscribeAsync(txt_mqttTopic.Text,MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce)
                .ContinueWith(task=> {
                    string topic = task.Result.First().TopicFilter.Topic;
                    lbl_SubTopic.Text = topic;

                    this.btn_MqttPub.Enabled = true;
                });
            }
        }

        private void btn_MqttPub_Click(object sender, EventArgs e)
        {
            if (mqttClient != null)
            {
                var appMsg = new MqttApplicationMessage(txt_mqttTopic.Text, Encoding.UTF8.GetBytes(txt_mqttSentContent.Text), MqttQualityOfServiceLevel.AtMostOnce, false);
                mqttClient.PublishAsync(appMsg).ContinueWith(t=> {
                    
                });
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ctrl_a
                && sender is TextBox) {
                TextBox textBox = sender as TextBox;
                textBox.SelectAll();
            }
        }
    }

}
