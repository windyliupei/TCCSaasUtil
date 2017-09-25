namespace ConcurrentNats
{
    partial class MainForm
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
            this.chk_natTls = new System.Windows.Forms.CheckBox();
            this.btn_Nas_Sub = new System.Windows.Forms.Button();
            this.btn_Nas_Disconn = new System.Windows.Forms.Button();
            this.btn_Nas_Connection = new System.Windows.Forms.Button();
            this.btn_Nas_Send = new System.Windows.Forms.Button();
            this.num_NasPort = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_natHost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_topic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_NasPort)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_natTls
            // 
            this.chk_natTls.AutoSize = true;
            this.chk_natTls.Checked = true;
            this.chk_natTls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_natTls.Location = new System.Drawing.Point(317, 56);
            this.chk_natTls.Name = "chk_natTls";
            this.chk_natTls.Size = new System.Drawing.Size(40, 17);
            this.chk_natTls.TabIndex = 35;
            this.chk_natTls.Text = "Tls";
            this.chk_natTls.UseVisualStyleBackColor = true;
            // 
            // btn_Nas_Sub
            // 
            this.btn_Nas_Sub.Enabled = false;
            this.btn_Nas_Sub.Location = new System.Drawing.Point(467, 67);
            this.btn_Nas_Sub.Name = "btn_Nas_Sub";
            this.btn_Nas_Sub.Size = new System.Drawing.Size(75, 23);
            this.btn_Nas_Sub.TabIndex = 34;
            this.btn_Nas_Sub.Text = "Sub";
            this.btn_Nas_Sub.UseVisualStyleBackColor = true;
            // 
            // btn_Nas_Disconn
            // 
            this.btn_Nas_Disconn.Enabled = false;
            this.btn_Nas_Disconn.Location = new System.Drawing.Point(467, 26);
            this.btn_Nas_Disconn.Name = "btn_Nas_Disconn";
            this.btn_Nas_Disconn.Size = new System.Drawing.Size(75, 23);
            this.btn_Nas_Disconn.TabIndex = 33;
            this.btn_Nas_Disconn.Text = "Disconnect";
            this.btn_Nas_Disconn.UseVisualStyleBackColor = true;
            // 
            // btn_Nas_Connection
            // 
            this.btn_Nas_Connection.Location = new System.Drawing.Point(378, 27);
            this.btn_Nas_Connection.Name = "btn_Nas_Connection";
            this.btn_Nas_Connection.Size = new System.Drawing.Size(75, 23);
            this.btn_Nas_Connection.TabIndex = 32;
            this.btn_Nas_Connection.Text = "Connect";
            this.btn_Nas_Connection.UseVisualStyleBackColor = true;
            // 
            // btn_Nas_Send
            // 
            this.btn_Nas_Send.Enabled = false;
            this.btn_Nas_Send.Location = new System.Drawing.Point(378, 67);
            this.btn_Nas_Send.Name = "btn_Nas_Send";
            this.btn_Nas_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Nas_Send.TabIndex = 31;
            this.btn_Nas_Send.Text = "Pub";
            this.btn_Nas_Send.UseVisualStyleBackColor = true;
            // 
            // num_NasPort
            // 
            this.num_NasPort.Location = new System.Drawing.Point(50, 55);
            this.num_NasPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.num_NasPort.Name = "num_NasPort";
            this.num_NasPort.Size = new System.Drawing.Size(100, 20);
            this.num_NasPort.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Port:";
            // 
            // txt_natHost
            // 
            this.txt_natHost.Location = new System.Drawing.Point(50, 23);
            this.txt_natHost.Name = "txt_natHost";
            this.txt_natHost.Size = new System.Drawing.Size(307, 20);
            this.txt_natHost.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Host:";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(457, 398);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 36;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Topic:";
            // 
            // txt_topic
            // 
            this.txt_topic.Location = new System.Drawing.Point(74, 134);
            this.txt_topic.Name = "txt_topic";
            this.txt_topic.Size = new System.Drawing.Size(307, 20);
            this.txt_topic.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 433);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.chk_natTls);
            this.Controls.Add(this.btn_Nas_Sub);
            this.Controls.Add(this.btn_Nas_Disconn);
            this.Controls.Add(this.btn_Nas_Connection);
            this.Controls.Add(this.btn_Nas_Send);
            this.Controls.Add(this.num_NasPort);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_topic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_natHost);
            this.Controls.Add(this.label14);
            this.Name = "MainForm";
            this.Text = "Concurrent Test of Nats";
            ((System.ComponentModel.ISupportInitialize)(this.num_NasPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_natTls;
        private System.Windows.Forms.Button btn_Nas_Sub;
        private System.Windows.Forms.Button btn_Nas_Disconn;
        private System.Windows.Forms.Button btn_Nas_Connection;
        private System.Windows.Forms.Button btn_Nas_Send;
        private System.Windows.Forms.NumericUpDown num_NasPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_natHost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_topic;
    }
}

