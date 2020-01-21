using NATS.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcurrentNats
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btn_run_Click(object sender, EventArgs e)
        {
            //TODO: Load from AppSetting.config, get the max
            IConnection natConn = NatsConnPool.Instance.Pop();

            IAsyncSubscription sAsync = natConn.SubscribeAsync(txt_topic.Text.Trim());

            //sAsync.MessageHandler += (nat_Sender, nat_e) =>
            //{
            //    txt_Nas_received.AppendText(string.Format("-----Received at:{0}-----", DateTime.Now));
            //    txt_Nas_received.AppendText("\r\n");
            //    txt_Nas_received.AppendText(System.Text.Encoding.Default.GetString(nat_e.Message.Data));
            //    txt_Nas_received.AppendText("\r\n");
            //    txt_Nas_received.AppendText("\r\n");
            //};
            sAsync.Start();


        }
    }
}
