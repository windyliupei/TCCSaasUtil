namespace WebSocketClient
{
    partial class WebSocketTestClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebSocketTestClient));
            this.txt_wsServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.txt_Received = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Conect = new System.Windows.Forms.Button();
            this.btn_Disconect = new System.Windows.Forms.Button();
            this.num_Port = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cmd = new System.Windows.Forms.TextBox();
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.cmb_isAuto = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_phoneUUID = new System.Windows.Forms.TextBox();
            this.txt_Application = new System.Windows.Forms.TextBox();
            this.num_login_isEncrypt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_schema = new System.Windows.Forms.ComboBox();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.num_login_port = new System.Windows.Forms.NumericUpDown();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_login_UserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_login_ReqUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_login_Host = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_send = new System.Windows.Forms.TabPage();
            this.btn_loadJSON = new System.Windows.Forms.Button();
            this.btn_SaveLog = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.cmb_wss = new System.Windows.Forms.ComboBox();
            this.chk_needLogin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tab_nats = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_Nas_SendContext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_Nas_received = new System.Windows.Forms.TextBox();
            this.chk_natTls = new System.Windows.Forms.CheckBox();
            this.btn_Nas_Sub = new System.Windows.Forms.Button();
            this.btn_Nas_Disconn = new System.Windows.Forms.Button();
            this.btn_Nas_Connection = new System.Windows.Forms.Button();
            this.btn_Nas_Send = new System.Windows.Forms.Button();
            this.num_NasPort = new System.Windows.Forms.NumericUpDown();
            this.txt_Nas_Topic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_natHost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabApi = new System.Windows.Forms.TabPage();
            this.btn_saveApiLog = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txt_ApiSend = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_ApiReceive = new System.Windows.Forms.TextBox();
            this.cmb_HttpMethod = new System.Windows.Forms.ComboBox();
            this.btn_SendApi = new System.Windows.Forms.Button();
            this.cmb_ApiAchema = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_ApiAction = new System.Windows.Forms.TextBox();
            this.txt_ApiHost = new System.Windows.Forms.TextBox();
            this.num_ApiPort = new System.Windows.Forms.NumericUpDown();
            this.tabmqtt = new System.Windows.Forms.TabPage();
            this.lbl_SubTopic = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.txt_mqttSentContent = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_mqttReceiveContent = new System.Windows.Forms.TextBox();
            this.txt_mqttTopic = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_MqttSub = new System.Windows.Forms.Button();
            this.btn_DisconnectMqtt = new System.Windows.Forms.Button();
            this.btn_mqttConnect = new System.Windows.Forms.Button();
            this.btn_MqttPub = new System.Windows.Forms.Button();
            this.num_mqttPort = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_mqttService = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_subTopic = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadInputSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveInputSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAndorid = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.num_Port)).BeginInit();
            this.tab_Control.SuspendLayout();
            this.tab_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_login_isEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_login_port)).BeginInit();
            this.tab_send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tab_nats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_NasPort)).BeginInit();
            this.tabApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ApiPort)).BeginInit();
            this.tabmqtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_mqttPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_wsServer
            // 
            this.txt_wsServer.Location = new System.Drawing.Point(142, 29);
            this.txt_wsServer.Name = "txt_wsServer";
            this.txt_wsServer.Size = new System.Drawing.Size(330, 21);
            this.txt_wsServer.TabIndex = 0;
            this.txt_wsServer.Text = "echo.websocket.org";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Address：";
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(421, 124);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 21);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.Location = new System.Drawing.Point(583, 84);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 21);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Send
            // 
            this.txt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Send.Location = new System.Drawing.Point(6, 41);
            this.txt_Send.Multiline = true;
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Send.Size = new System.Drawing.Size(666, 119);
            this.txt_Send.TabIndex = 0;
            // 
            // txt_Received
            // 
            this.txt_Received.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Received.Location = new System.Drawing.Point(6, 23);
            this.txt_Received.Multiline = true;
            this.txt_Received.Name = "txt_Received";
            this.txt_Received.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Received.Size = new System.Drawing.Size(666, 148);
            this.txt_Received.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Send Context:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Received Context:";
            // 
            // btn_Conect
            // 
            this.btn_Conect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Conect.Location = new System.Drawing.Point(421, 84);
            this.btn_Conect.Name = "btn_Conect";
            this.btn_Conect.Size = new System.Drawing.Size(75, 21);
            this.btn_Conect.TabIndex = 2;
            this.btn_Conect.Text = "Connect";
            this.btn_Conect.UseVisualStyleBackColor = true;
            this.btn_Conect.Click += new System.EventHandler(this.btn_Conect_Click);
            // 
            // btn_Disconect
            // 
            this.btn_Disconect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Disconect.Location = new System.Drawing.Point(502, 84);
            this.btn_Disconect.Name = "btn_Disconect";
            this.btn_Disconect.Size = new System.Drawing.Size(75, 21);
            this.btn_Disconect.TabIndex = 2;
            this.btn_Disconect.Text = "Disconect";
            this.btn_Disconect.UseVisualStyleBackColor = true;
            this.btn_Disconect.Click += new System.EventHandler(this.btn_Disconect_Click);
            // 
            // num_Port
            // 
            this.num_Port.Location = new System.Drawing.Point(510, 28);
            this.num_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_Port.Name = "num_Port";
            this.num_Port.Size = new System.Drawing.Size(57, 21);
            this.num_Port.TabIndex = 7;
            this.num_Port.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Command(开头要写/)";
            // 
            // txt_Cmd
            // 
            this.txt_Cmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cmd.Location = new System.Drawing.Point(141, 60);
            this.txt_Cmd.Name = "txt_Cmd";
            this.txt_Cmd.Size = new System.Drawing.Size(517, 21);
            this.txt_Cmd.TabIndex = 10;
            // 
            // tab_Control
            // 
            this.tab_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Control.Controls.Add(this.tab_login);
            this.tab_Control.Controls.Add(this.tab_send);
            this.tab_Control.Controls.Add(this.tab_nats);
            this.tab_Control.Controls.Add(this.tabApi);
            this.tab_Control.Controls.Add(this.tabmqtt);
            this.tab_Control.Controls.Add(this.tabAndorid);
            this.tab_Control.Location = new System.Drawing.Point(0, 25);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(720, 549);
            this.tab_Control.TabIndex = 11;
            // 
            // tab_login
            // 
            this.tab_login.Controls.Add(this.cmb_isAuto);
            this.tab_login.Controls.Add(this.label21);
            this.tab_login.Controls.Add(this.label20);
            this.tab_login.Controls.Add(this.cmb_language);
            this.tab_login.Controls.Add(this.label19);
            this.tab_login.Controls.Add(this.label18);
            this.tab_login.Controls.Add(this.label17);
            this.tab_login.Controls.Add(this.txt_phoneUUID);
            this.tab_login.Controls.Add(this.txt_Application);
            this.tab_login.Controls.Add(this.num_login_isEncrypt);
            this.tab_login.Controls.Add(this.label11);
            this.tab_login.Controls.Add(this.cmb_schema);
            this.tab_login.Controls.Add(this.btn_login_login);
            this.tab_login.Controls.Add(this.num_login_port);
            this.tab_login.Controls.Add(this.txt_login_password);
            this.tab_login.Controls.Add(this.label10);
            this.tab_login.Controls.Add(this.txt_login_UserName);
            this.tab_login.Controls.Add(this.label9);
            this.tab_login.Controls.Add(this.txt_login_ReqUrl);
            this.tab_login.Controls.Add(this.label8);
            this.tab_login.Controls.Add(this.label7);
            this.tab_login.Controls.Add(this.txt_login_Host);
            this.tab_login.Controls.Add(this.label6);
            this.tab_login.Location = new System.Drawing.Point(4, 22);
            this.tab_login.Name = "tab_login";
            this.tab_login.Padding = new System.Windows.Forms.Padding(3);
            this.tab_login.Size = new System.Drawing.Size(712, 523);
            this.tab_login.TabIndex = 0;
            this.tab_login.Text = "Login";
            this.tab_login.UseVisualStyleBackColor = true;
            // 
            // cmb_isAuto
            // 
            this.cmb_isAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_isAuto.FormattingEnabled = true;
            this.cmb_isAuto.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmb_isAuto.Location = new System.Drawing.Point(85, 396);
            this.cmb_isAuto.Name = "cmb_isAuto";
            this.cmb_isAuto.Size = new System.Drawing.Size(97, 20);
            this.cmb_isAuto.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 399);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 22;
            this.label21.Text = "IsAutoLogin:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 367);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 21;
            this.label20.Text = "Language:";
            // 
            // cmb_language
            // 
            this.cmb_language.FormattingEnabled = true;
            this.cmb_language.Items.AddRange(new object[] {
            "en_us",
            "zh_cn"});
            this.cmb_language.Location = new System.Drawing.Point(85, 360);
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.Size = new System.Drawing.Size(97, 20);
            this.cmb_language.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 19;
            this.label19.Text = "Schema:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 282);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 18;
            this.label18.Text = "Application:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 330);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "Phone UUID:";
            // 
            // txt_phoneUUID
            // 
            this.txt_phoneUUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phoneUUID.Location = new System.Drawing.Point(85, 323);
            this.txt_phoneUUID.Name = "txt_phoneUUID";
            this.txt_phoneUUID.Size = new System.Drawing.Size(607, 21);
            this.txt_phoneUUID.TabIndex = 16;
            this.txt_phoneUUID.Text = "237b42b-0ce7-4582-830c-34d930b1fd52";
            // 
            // txt_Application
            // 
            this.txt_Application.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Application.Location = new System.Drawing.Point(85, 276);
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.Size = new System.Drawing.Size(607, 21);
            this.txt_Application.TabIndex = 16;
            this.txt_Application.Text = "237b42b-0ce7-4582-830c-34d930b1fd52";
            // 
            // num_login_isEncrypt
            // 
            this.num_login_isEncrypt.Location = new System.Drawing.Point(85, 240);
            this.num_login_isEncrypt.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_login_isEncrypt.Name = "num_login_isEncrypt";
            this.num_login_isEncrypt.Size = new System.Drawing.Size(100, 21);
            this.num_login_isEncrypt.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "IsEncrypt:";
            // 
            // cmb_schema
            // 
            this.cmb_schema.FormattingEnabled = true;
            this.cmb_schema.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.cmb_schema.Location = new System.Drawing.Point(85, 38);
            this.cmb_schema.Name = "cmb_schema";
            this.cmb_schema.Size = new System.Drawing.Size(97, 20);
            this.cmb_schema.TabIndex = 12;
            // 
            // btn_login_login
            // 
            this.btn_login_login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_login_login.Location = new System.Drawing.Point(617, 399);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(75, 21);
            this.btn_login_login.TabIndex = 11;
            this.btn_login_login.Text = "Login";
            this.btn_login_login.UseVisualStyleBackColor = true;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // num_login_port
            // 
            this.num_login_port.Location = new System.Drawing.Point(85, 110);
            this.num_login_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_login_port.Name = "num_login_port";
            this.num_login_port.Size = new System.Drawing.Size(100, 21);
            this.num_login_port.TabIndex = 10;
            this.num_login_port.Value = new decimal(new int[] {
            443,
            0,
            0,
            0});
            // 
            // txt_login_password
            // 
            this.txt_login_password.Location = new System.Drawing.Point(85, 205);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(222, 21);
            this.txt_login_password.TabIndex = 9;
            this.txt_login_password.Text = "12345678";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "Password:";
            // 
            // txt_login_UserName
            // 
            this.txt_login_UserName.Location = new System.Drawing.Point(85, 173);
            this.txt_login_UserName.Name = "txt_login_UserName";
            this.txt_login_UserName.Size = new System.Drawing.Size(222, 21);
            this.txt_login_UserName.TabIndex = 7;
            this.txt_login_UserName.Text = "test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "User Name:";
            // 
            // txt_login_ReqUrl
            // 
            this.txt_login_ReqUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_login_ReqUrl.Location = new System.Drawing.Point(85, 139);
            this.txt_login_ReqUrl.Name = "txt_login_ReqUrl";
            this.txt_login_ReqUrl.Size = new System.Drawing.Size(607, 21);
            this.txt_login_ReqUrl.TabIndex = 5;
            this.txt_login_ReqUrl.Text = "/v1/api/user/login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Request URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port:";
            // 
            // txt_login_Host
            // 
            this.txt_login_Host.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_login_Host.Location = new System.Drawing.Point(85, 72);
            this.txt_login_Host.Name = "txt_login_Host";
            this.txt_login_Host.Size = new System.Drawing.Size(607, 21);
            this.txt_login_Host.TabIndex = 1;
            this.txt_login_Host.Text = "qa.homecloud.honeywell.com.cn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Host:";
            // 
            // tab_send
            // 
            this.tab_send.Controls.Add(this.btn_loadJSON);
            this.tab_send.Controls.Add(this.btn_SaveLog);
            this.tab_send.Controls.Add(this.splitContainer3);
            this.tab_send.Controls.Add(this.cmb_wss);
            this.tab_send.Controls.Add(this.chk_needLogin);
            this.tab_send.Controls.Add(this.label5);
            this.tab_send.Controls.Add(this.label1);
            this.tab_send.Controls.Add(this.txt_Cmd);
            this.tab_send.Controls.Add(this.txt_wsServer);
            this.tab_send.Controls.Add(this.label4);
            this.tab_send.Controls.Add(this.btn_Send);
            this.tab_send.Controls.Add(this.num_Port);
            this.tab_send.Controls.Add(this.btn_Conect);
            this.tab_send.Controls.Add(this.btn_Clear);
            this.tab_send.Controls.Add(this.btn_Disconect);
            this.tab_send.Location = new System.Drawing.Point(4, 22);
            this.tab_send.Name = "tab_send";
            this.tab_send.Padding = new System.Windows.Forms.Padding(3);
            this.tab_send.Size = new System.Drawing.Size(712, 523);
            this.tab_send.TabIndex = 1;
            this.tab_send.Text = "Web Socket Send";
            this.tab_send.UseVisualStyleBackColor = true;
            // 
            // btn_loadJSON
            // 
            this.btn_loadJSON.Location = new System.Drawing.Point(583, 123);
            this.btn_loadJSON.Name = "btn_loadJSON";
            this.btn_loadJSON.Size = new System.Drawing.Size(75, 21);
            this.btn_loadJSON.TabIndex = 16;
            this.btn_loadJSON.Text = "Load JSON";
            this.btn_loadJSON.UseVisualStyleBackColor = true;
            this.btn_loadJSON.Click += new System.EventHandler(this.btn_loadJSON_Click);
            // 
            // btn_SaveLog
            // 
            this.btn_SaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveLog.Location = new System.Drawing.Point(502, 123);
            this.btn_SaveLog.Name = "btn_SaveLog";
            this.btn_SaveLog.Size = new System.Drawing.Size(75, 21);
            this.btn_SaveLog.TabIndex = 15;
            this.btn_SaveLog.Text = "Save Log";
            this.btn_SaveLog.UseVisualStyleBackColor = true;
            this.btn_SaveLog.Click += new System.EventHandler(this.btn_SaveLog_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(8, 150);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.txt_Send);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.txt_Received);
            this.splitContainer3.Size = new System.Drawing.Size(684, 350);
            this.splitContainer3.SplitterDistance = 172;
            this.splitContainer3.TabIndex = 14;
            // 
            // cmb_wss
            // 
            this.cmb_wss.FormattingEnabled = true;
            this.cmb_wss.Items.AddRange(new object[] {
            "ws://",
            "wss://"});
            this.cmb_wss.Location = new System.Drawing.Point(12, 29);
            this.cmb_wss.Name = "cmb_wss";
            this.cmb_wss.Size = new System.Drawing.Size(123, 20);
            this.cmb_wss.TabIndex = 13;
            // 
            // chk_needLogin
            // 
            this.chk_needLogin.AutoSize = true;
            this.chk_needLogin.Checked = true;
            this.chk_needLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_needLogin.Location = new System.Drawing.Point(142, 116);
            this.chk_needLogin.Name = "chk_needLogin";
            this.chk_needLogin.Size = new System.Drawing.Size(84, 16);
            this.chk_needLogin.TabIndex = 12;
            this.chk_needLogin.Text = "Need Login";
            this.chk_needLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port";
            // 
            // tab_nats
            // 
            this.tab_nats.Controls.Add(this.splitContainer1);
            this.tab_nats.Controls.Add(this.chk_natTls);
            this.tab_nats.Controls.Add(this.btn_Nas_Sub);
            this.tab_nats.Controls.Add(this.btn_Nas_Disconn);
            this.tab_nats.Controls.Add(this.btn_Nas_Connection);
            this.tab_nats.Controls.Add(this.btn_Nas_Send);
            this.tab_nats.Controls.Add(this.num_NasPort);
            this.tab_nats.Controls.Add(this.txt_Nas_Topic);
            this.tab_nats.Controls.Add(this.label12);
            this.tab_nats.Controls.Add(this.label13);
            this.tab_nats.Controls.Add(this.txt_natHost);
            this.tab_nats.Controls.Add(this.label14);
            this.tab_nats.Location = new System.Drawing.Point(4, 22);
            this.tab_nats.Name = "tab_nats";
            this.tab_nats.Size = new System.Drawing.Size(712, 523);
            this.tab_nats.TabIndex = 2;
            this.tab_nats.Text = "Nats";
            this.tab_nats.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 133);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_Nas_SendContext);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label16);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Nas_received);
            this.splitContainer1.Size = new System.Drawing.Size(681, 379);
            this.splitContainer1.SplitterDistance = 188;
            this.splitContainer1.TabIndex = 27;
            // 
            // txt_Nas_SendContext
            // 
            this.txt_Nas_SendContext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nas_SendContext.Location = new System.Drawing.Point(6, 23);
            this.txt_Nas_SendContext.Multiline = true;
            this.txt_Nas_SendContext.Name = "txt_Nas_SendContext";
            this.txt_Nas_SendContext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Nas_SendContext.Size = new System.Drawing.Size(630, 154);
            this.txt_Nas_SendContext.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 18;
            this.label15.Text = "Send Context:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "Received Context:";
            // 
            // txt_Nas_received
            // 
            this.txt_Nas_received.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nas_received.Location = new System.Drawing.Point(6, 15);
            this.txt_Nas_received.Multiline = true;
            this.txt_Nas_received.Name = "txt_Nas_received";
            this.txt_Nas_received.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Nas_received.Size = new System.Drawing.Size(630, 154);
            this.txt_Nas_received.TabIndex = 21;
            // 
            // chk_natTls
            // 
            this.chk_natTls.AutoSize = true;
            this.chk_natTls.Location = new System.Drawing.Point(207, 65);
            this.chk_natTls.Name = "chk_natTls";
            this.chk_natTls.Size = new System.Drawing.Size(42, 16);
            this.chk_natTls.TabIndex = 26;
            this.chk_natTls.Text = "Tls";
            this.chk_natTls.UseVisualStyleBackColor = true;
            // 
            // btn_Nas_Sub
            // 
            this.btn_Nas_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nas_Sub.Enabled = false;
            this.btn_Nas_Sub.Location = new System.Drawing.Point(579, 91);
            this.btn_Nas_Sub.Name = "btn_Nas_Sub";
            this.btn_Nas_Sub.Size = new System.Drawing.Size(75, 21);
            this.btn_Nas_Sub.TabIndex = 25;
            this.btn_Nas_Sub.Text = "Sub";
            this.btn_Nas_Sub.UseVisualStyleBackColor = true;
            this.btn_Nas_Sub.Click += new System.EventHandler(this.btn_Nas_Sub_Click);
            // 
            // btn_Nas_Disconn
            // 
            this.btn_Nas_Disconn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nas_Disconn.Enabled = false;
            this.btn_Nas_Disconn.Location = new System.Drawing.Point(579, 54);
            this.btn_Nas_Disconn.Name = "btn_Nas_Disconn";
            this.btn_Nas_Disconn.Size = new System.Drawing.Size(75, 21);
            this.btn_Nas_Disconn.TabIndex = 24;
            this.btn_Nas_Disconn.Text = "Disconnect";
            this.btn_Nas_Disconn.UseVisualStyleBackColor = true;
            this.btn_Nas_Disconn.Click += new System.EventHandler(this.btn_Nas_Disconn_Click);
            // 
            // btn_Nas_Connection
            // 
            this.btn_Nas_Connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nas_Connection.Location = new System.Drawing.Point(490, 54);
            this.btn_Nas_Connection.Name = "btn_Nas_Connection";
            this.btn_Nas_Connection.Size = new System.Drawing.Size(75, 21);
            this.btn_Nas_Connection.TabIndex = 23;
            this.btn_Nas_Connection.Text = "Connect";
            this.btn_Nas_Connection.UseVisualStyleBackColor = true;
            this.btn_Nas_Connection.Click += new System.EventHandler(this.btn_Nas_Connection_Click);
            // 
            // btn_Nas_Send
            // 
            this.btn_Nas_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nas_Send.Enabled = false;
            this.btn_Nas_Send.Location = new System.Drawing.Point(490, 91);
            this.btn_Nas_Send.Name = "btn_Nas_Send";
            this.btn_Nas_Send.Size = new System.Drawing.Size(75, 21);
            this.btn_Nas_Send.TabIndex = 19;
            this.btn_Nas_Send.Text = "Pub";
            this.btn_Nas_Send.UseVisualStyleBackColor = true;
            this.btn_Nas_Send.Click += new System.EventHandler(this.btn_Nas_Send_Click);
            // 
            // num_NasPort
            // 
            this.num_NasPort.Location = new System.Drawing.Point(85, 62);
            this.num_NasPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_NasPort.Name = "num_NasPort";
            this.num_NasPort.Size = new System.Drawing.Size(100, 21);
            this.num_NasPort.TabIndex = 16;
            this.num_NasPort.Value = new decimal(new int[] {
            4222,
            0,
            0,
            0});
            // 
            // txt_Nas_Topic
            // 
            this.txt_Nas_Topic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nas_Topic.Location = new System.Drawing.Point(85, 91);
            this.txt_Nas_Topic.Name = "txt_Nas_Topic";
            this.txt_Nas_Topic.Size = new System.Drawing.Size(372, 21);
            this.txt_Nas_Topic.TabIndex = 15;
            this.txt_Nas_Topic.Text = "toIot.>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "Topic:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "Port:";
            // 
            // txt_natHost
            // 
            this.txt_natHost.Location = new System.Drawing.Point(85, 24);
            this.txt_natHost.Name = "txt_natHost";
            this.txt_natHost.Size = new System.Drawing.Size(222, 21);
            this.txt_natHost.TabIndex = 12;
            this.txt_natHost.Text = "127.0.0.1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "Host:";
            // 
            // tabApi
            // 
            this.tabApi.Controls.Add(this.btn_saveApiLog);
            this.tabApi.Controls.Add(this.splitContainer2);
            this.tabApi.Controls.Add(this.cmb_HttpMethod);
            this.tabApi.Controls.Add(this.btn_SendApi);
            this.tabApi.Controls.Add(this.cmb_ApiAchema);
            this.tabApi.Controls.Add(this.label22);
            this.tabApi.Controls.Add(this.txt_ApiAction);
            this.tabApi.Controls.Add(this.txt_ApiHost);
            this.tabApi.Controls.Add(this.num_ApiPort);
            this.tabApi.Location = new System.Drawing.Point(4, 22);
            this.tabApi.Name = "tabApi";
            this.tabApi.Padding = new System.Windows.Forms.Padding(3);
            this.tabApi.Size = new System.Drawing.Size(712, 523);
            this.tabApi.TabIndex = 3;
            this.tabApi.Text = "WebApi";
            this.tabApi.UseVisualStyleBackColor = true;
            // 
            // btn_saveApiLog
            // 
            this.btn_saveApiLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_saveApiLog.Location = new System.Drawing.Point(626, 88);
            this.btn_saveApiLog.Name = "btn_saveApiLog";
            this.btn_saveApiLog.Size = new System.Drawing.Size(75, 21);
            this.btn_saveApiLog.TabIndex = 28;
            this.btn_saveApiLog.Text = "Save Log";
            this.btn_saveApiLog.UseVisualStyleBackColor = true;
            this.btn_saveApiLog.Click += new System.EventHandler(this.btn_saveApiLog_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(8, 114);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txt_ApiSend);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label23);
            this.splitContainer2.Panel2.Controls.Add(this.txt_ApiReceive);
            this.splitContainer2.Size = new System.Drawing.Size(696, 366);
            this.splitContainer2.SplitterDistance = 181;
            this.splitContainer2.TabIndex = 27;
            // 
            // txt_ApiSend
            // 
            this.txt_ApiSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApiSend.Location = new System.Drawing.Point(6, 22);
            this.txt_ApiSend.Multiline = true;
            this.txt_ApiSend.Name = "txt_ApiSend";
            this.txt_ApiSend.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ApiSend.Size = new System.Drawing.Size(671, 148);
            this.txt_ApiSend.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 24;
            this.label24.Text = "Send Context:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 12);
            this.label23.TabIndex = 25;
            this.label23.Text = "Received Context:";
            // 
            // txt_ApiReceive
            // 
            this.txt_ApiReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApiReceive.Location = new System.Drawing.Point(7, 23);
            this.txt_ApiReceive.Multiline = true;
            this.txt_ApiReceive.Name = "txt_ApiReceive";
            this.txt_ApiReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ApiReceive.Size = new System.Drawing.Size(670, 146);
            this.txt_ApiReceive.TabIndex = 23;
            // 
            // cmb_HttpMethod
            // 
            this.cmb_HttpMethod.FormattingEnabled = true;
            this.cmb_HttpMethod.Items.AddRange(new object[] {
            "POST",
            "GET",
            "PUT",
            "DELETE"});
            this.cmb_HttpMethod.Location = new System.Drawing.Point(111, 68);
            this.cmb_HttpMethod.Name = "cmb_HttpMethod";
            this.cmb_HttpMethod.Size = new System.Drawing.Size(97, 20);
            this.cmb_HttpMethod.TabIndex = 26;
            // 
            // btn_SendApi
            // 
            this.btn_SendApi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SendApi.Location = new System.Drawing.Point(545, 88);
            this.btn_SendApi.Name = "btn_SendApi";
            this.btn_SendApi.Size = new System.Drawing.Size(75, 21);
            this.btn_SendApi.TabIndex = 21;
            this.btn_SendApi.Text = "Send";
            this.btn_SendApi.UseVisualStyleBackColor = true;
            this.btn_SendApi.Click += new System.EventHandler(this.btn_SendApi_Click);
            // 
            // cmb_ApiAchema
            // 
            this.cmb_ApiAchema.FormattingEnabled = true;
            this.cmb_ApiAchema.Items.AddRange(new object[] {
            "http://",
            "https://"});
            this.cmb_ApiAchema.Location = new System.Drawing.Point(8, 11);
            this.cmb_ApiAchema.Name = "cmb_ApiAchema";
            this.cmb_ApiAchema.Size = new System.Drawing.Size(97, 20);
            this.cmb_ApiAchema.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(474, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 16;
            this.label22.Text = "Port";
            // 
            // txt_ApiAction
            // 
            this.txt_ApiAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ApiAction.Location = new System.Drawing.Point(111, 44);
            this.txt_ApiAction.Name = "txt_ApiAction";
            this.txt_ApiAction.Size = new System.Drawing.Size(343, 21);
            this.txt_ApiAction.TabIndex = 15;
            this.txt_ApiAction.Text = "v1/websocket";
            // 
            // txt_ApiHost
            // 
            this.txt_ApiHost.Location = new System.Drawing.Point(111, 11);
            this.txt_ApiHost.Name = "txt_ApiHost";
            this.txt_ApiHost.Size = new System.Drawing.Size(348, 21);
            this.txt_ApiHost.TabIndex = 12;
            this.txt_ApiHost.Text = "localhost";
            // 
            // num_ApiPort
            // 
            this.num_ApiPort.Location = new System.Drawing.Point(506, 12);
            this.num_ApiPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_ApiPort.Name = "num_ApiPort";
            this.num_ApiPort.Size = new System.Drawing.Size(57, 21);
            this.num_ApiPort.TabIndex = 13;
            this.num_ApiPort.Value = new decimal(new int[] {
            8082,
            0,
            0,
            0});
            // 
            // tabmqtt
            // 
            this.tabmqtt.Controls.Add(this.lbl_SubTopic);
            this.tabmqtt.Controls.Add(this.label30);
            this.tabmqtt.Controls.Add(this.splitContainer4);
            this.tabmqtt.Controls.Add(this.txt_mqttTopic);
            this.tabmqtt.Controls.Add(this.label27);
            this.tabmqtt.Controls.Add(this.btn_MqttSub);
            this.tabmqtt.Controls.Add(this.btn_DisconnectMqtt);
            this.tabmqtt.Controls.Add(this.btn_mqttConnect);
            this.tabmqtt.Controls.Add(this.btn_MqttPub);
            this.tabmqtt.Controls.Add(this.num_mqttPort);
            this.tabmqtt.Controls.Add(this.label25);
            this.tabmqtt.Controls.Add(this.txt_mqttService);
            this.tabmqtt.Controls.Add(this.label26);
            this.tabmqtt.Location = new System.Drawing.Point(4, 22);
            this.tabmqtt.Margin = new System.Windows.Forms.Padding(2);
            this.tabmqtt.Name = "tabmqtt";
            this.tabmqtt.Size = new System.Drawing.Size(712, 523);
            this.tabmqtt.TabIndex = 4;
            this.tabmqtt.Text = "MQTT";
            this.tabmqtt.UseVisualStyleBackColor = true;
            // 
            // lbl_SubTopic
            // 
            this.lbl_SubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SubTopic.AutoSize = true;
            this.lbl_SubTopic.Location = new System.Drawing.Point(75, 507);
            this.lbl_SubTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SubTopic.Name = "lbl_SubTopic";
            this.lbl_SubTopic.Size = new System.Drawing.Size(0, 12);
            this.lbl_SubTopic.TabIndex = 38;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 507);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 37;
            this.label30.Text = "Now Sub:";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Location = new System.Drawing.Point(15, 139);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.txt_mqttSentContent);
            this.splitContainer4.Panel1.Controls.Add(this.label28);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label29);
            this.splitContainer4.Panel2.Controls.Add(this.txt_mqttReceiveContent);
            this.splitContainer4.Size = new System.Drawing.Size(673, 379);
            this.splitContainer4.SplitterDistance = 188;
            this.splitContainer4.TabIndex = 36;
            // 
            // txt_mqttSentContent
            // 
            this.txt_mqttSentContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mqttSentContent.Location = new System.Drawing.Point(6, 23);
            this.txt_mqttSentContent.Multiline = true;
            this.txt_mqttSentContent.Name = "txt_mqttSentContent";
            this.txt_mqttSentContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_mqttSentContent.Size = new System.Drawing.Size(654, 150);
            this.txt_mqttSentContent.TabIndex = 17;
            this.txt_mqttSentContent.Text = "{\"Key\":\"value\"}";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 12);
            this.label28.TabIndex = 18;
            this.label28.Text = "Send Context:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 12);
            this.label29.TabIndex = 22;
            this.label29.Text = "Received Context:";
            // 
            // txt_mqttReceiveContent
            // 
            this.txt_mqttReceiveContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mqttReceiveContent.Location = new System.Drawing.Point(6, 15);
            this.txt_mqttReceiveContent.Multiline = true;
            this.txt_mqttReceiveContent.Name = "txt_mqttReceiveContent";
            this.txt_mqttReceiveContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_mqttReceiveContent.Size = new System.Drawing.Size(654, 153);
            this.txt_mqttReceiveContent.TabIndex = 21;
            // 
            // txt_mqttTopic
            // 
            this.txt_mqttTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mqttTopic.Location = new System.Drawing.Point(91, 97);
            this.txt_mqttTopic.Name = "txt_mqttTopic";
            this.txt_mqttTopic.Size = new System.Drawing.Size(372, 21);
            this.txt_mqttTopic.TabIndex = 35;
            this.txt_mqttTopic.Text = "toCloud/144146000012";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 34;
            this.label27.Text = "Topic:";
            // 
            // btn_MqttSub
            // 
            this.btn_MqttSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MqttSub.Enabled = false;
            this.btn_MqttSub.Location = new System.Drawing.Point(584, 95);
            this.btn_MqttSub.Name = "btn_MqttSub";
            this.btn_MqttSub.Size = new System.Drawing.Size(75, 21);
            this.btn_MqttSub.TabIndex = 33;
            this.btn_MqttSub.Text = "Sub";
            this.btn_MqttSub.UseVisualStyleBackColor = true;
            this.btn_MqttSub.Click += new System.EventHandler(this.btnMqttSub_Click);
            // 
            // btn_DisconnectMqtt
            // 
            this.btn_DisconnectMqtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisconnectMqtt.Enabled = false;
            this.btn_DisconnectMqtt.Location = new System.Drawing.Point(584, 56);
            this.btn_DisconnectMqtt.Name = "btn_DisconnectMqtt";
            this.btn_DisconnectMqtt.Size = new System.Drawing.Size(75, 21);
            this.btn_DisconnectMqtt.TabIndex = 32;
            this.btn_DisconnectMqtt.Text = "Disconnect";
            this.btn_DisconnectMqtt.UseVisualStyleBackColor = true;
            this.btn_DisconnectMqtt.Click += new System.EventHandler(this.btn_DisconnectMqtt_Click);
            // 
            // btn_mqttConnect
            // 
            this.btn_mqttConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mqttConnect.Location = new System.Drawing.Point(495, 58);
            this.btn_mqttConnect.Name = "btn_mqttConnect";
            this.btn_mqttConnect.Size = new System.Drawing.Size(75, 21);
            this.btn_mqttConnect.TabIndex = 31;
            this.btn_mqttConnect.Text = "Connect";
            this.btn_mqttConnect.UseVisualStyleBackColor = true;
            this.btn_mqttConnect.Click += new System.EventHandler(this.btnMqttConnect_Click);
            // 
            // btn_MqttPub
            // 
            this.btn_MqttPub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MqttPub.Enabled = false;
            this.btn_MqttPub.Location = new System.Drawing.Point(495, 95);
            this.btn_MqttPub.Name = "btn_MqttPub";
            this.btn_MqttPub.Size = new System.Drawing.Size(75, 21);
            this.btn_MqttPub.TabIndex = 30;
            this.btn_MqttPub.Text = "Pub";
            this.btn_MqttPub.UseVisualStyleBackColor = true;
            this.btn_MqttPub.Click += new System.EventHandler(this.btn_MqttPub_Click);
            // 
            // num_mqttPort
            // 
            this.num_mqttPort.Location = new System.Drawing.Point(91, 66);
            this.num_mqttPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_mqttPort.Name = "num_mqttPort";
            this.num_mqttPort.Size = new System.Drawing.Size(100, 21);
            this.num_mqttPort.TabIndex = 29;
            this.num_mqttPort.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 67);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 28;
            this.label25.Text = "Port:";
            // 
            // txt_mqttService
            // 
            this.txt_mqttService.Location = new System.Drawing.Point(91, 28);
            this.txt_mqttService.Name = "txt_mqttService";
            this.txt_mqttService.Size = new System.Drawing.Size(222, 21);
            this.txt_mqttService.TabIndex = 27;
            this.txt_mqttService.Text = "127.0.0.1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(13, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 26;
            this.label26.Text = "Host:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tss_subTopic});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "Connect Status:";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 20);
            this.toolStripSplitButton1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel2.Text = "Not login";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel3.Text = "Current sub:";
            // 
            // tss_subTopic
            // 
            this.tss_subTopic.ForeColor = System.Drawing.Color.Red;
            this.tss_subTopic.Name = "tss_subTopic";
            this.tss_subTopic.Size = new System.Drawing.Size(113, 17);
            this.tss_subTopic.Text = "Not Sub any topic";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadInputSettingToolStripMenuItem,
            this.saveInputSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadInputSettingToolStripMenuItem
            // 
            this.loadInputSettingToolStripMenuItem.Name = "loadInputSettingToolStripMenuItem";
            this.loadInputSettingToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.loadInputSettingToolStripMenuItem.Text = "Load Input Setting";
            this.loadInputSettingToolStripMenuItem.Click += new System.EventHandler(this.loadInputSettingToolStripMenuItem_Click);
            // 
            // saveInputSettingToolStripMenuItem
            // 
            this.saveInputSettingToolStripMenuItem.Name = "saveInputSettingToolStripMenuItem";
            this.saveInputSettingToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.saveInputSettingToolStripMenuItem.Text = "Save Input Setting";
            this.saveInputSettingToolStripMenuItem.Click += new System.EventHandler(this.saveInputSettingToolStripMenuItem_Click);
            // 
            // tabAndorid
            // 
            this.tabAndorid.Location = new System.Drawing.Point(4, 22);
            this.tabAndorid.Name = "tabAndorid";
            this.tabAndorid.Padding = new System.Windows.Forms.Padding(3);
            this.tabAndorid.Size = new System.Drawing.Size(712, 523);
            this.tabAndorid.TabIndex = 5;
            this.tabAndorid.Text = "Android";
            this.tabAndorid.UseVisualStyleBackColor = true;
            // 
            // WebSocketTestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tab_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 557);
            this.Name = "WebSocketTestClient";
            this.Text = "WebSocket & Nats Client";
            this.Load += new System.EventHandler(this.WebSocketClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Port)).EndInit();
            this.tab_Control.ResumeLayout(false);
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_login_isEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_login_port)).EndInit();
            this.tab_send.ResumeLayout(false);
            this.tab_send.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tab_nats.ResumeLayout(false);
            this.tab_nats.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_NasPort)).EndInit();
            this.tabApi.ResumeLayout(false);
            this.tabApi.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_ApiPort)).EndInit();
            this.tabmqtt.ResumeLayout(false);
            this.tabmqtt.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_mqttPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_wsServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.TextBox txt_Received;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Conect;
        private System.Windows.Forms.Button btn_Disconect;
        private System.Windows.Forms.NumericUpDown num_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cmd;
        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.TabPage tab_send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.NumericUpDown num_login_port;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_login_UserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_login_ReqUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_login_Host;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.ComboBox cmb_schema;
        private System.Windows.Forms.NumericUpDown num_login_isEncrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tab_nats;
        private System.Windows.Forms.NumericUpDown num_NasPort;
        private System.Windows.Forms.TextBox txt_Nas_Topic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_natHost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Nas_Send;
        private System.Windows.Forms.TextBox txt_Nas_SendContext;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Nas_received;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_phoneUUID;
        private System.Windows.Forms.TextBox txt_Application;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadInputSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInputSettingToolStripMenuItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_isAuto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_Nas_Sub;
        private System.Windows.Forms.Button btn_Nas_Disconn;
        private System.Windows.Forms.Button btn_Nas_Connection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tss_subTopic;
        private System.Windows.Forms.CheckBox chk_needLogin;
        private System.Windows.Forms.TabPage tabApi;
        private System.Windows.Forms.ComboBox cmb_ApiAchema;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_ApiAction;
        private System.Windows.Forms.TextBox txt_ApiHost;
        private System.Windows.Forms.NumericUpDown num_ApiPort;
        private System.Windows.Forms.TextBox txt_ApiSend;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_ApiReceive;
        private System.Windows.Forms.Button btn_SendApi;
        private System.Windows.Forms.ComboBox cmb_HttpMethod;
        private System.Windows.Forms.CheckBox chk_natTls;
        private System.Windows.Forms.ComboBox cmb_wss;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button btn_SaveLog;
        private System.Windows.Forms.Button btn_saveApiLog;
        private System.Windows.Forms.TabPage tabmqtt;
        private System.Windows.Forms.Button btn_MqttSub;
        private System.Windows.Forms.Button btn_DisconnectMqtt;
        private System.Windows.Forms.Button btn_mqttConnect;
        private System.Windows.Forms.Button btn_MqttPub;
        private System.Windows.Forms.NumericUpDown num_mqttPort;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_mqttService;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox txt_mqttSentContent;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_mqttReceiveContent;
        private System.Windows.Forms.TextBox txt_mqttTopic;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbl_SubTopic;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_loadJSON;
        private System.Windows.Forms.TabPage tabAndorid;
    }
}

