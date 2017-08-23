using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketClient
{
    public partial class SaveInputWindow : Form
    {
        WebSocketTestClient _webClient;
        public SaveInputWindow(WebSocketTestClient webClient)
        {
            InitializeComponent();
            _webClient = webClient;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btm_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SettingName.Text))
            {
                MessageBox.Show("Please input a name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, InputSetting> settings = SettingNamager.Instance.GetSettingList();

            DialogResult askResult = System.Windows.Forms.DialogResult.No;
            if (settings.ContainsKey(txt_SettingName.Text))
            {
                askResult = MessageBox.Show(string.Format("Same setting :'{0}' was already existed, would you like update it?", txt_SettingName.Text.Trim()),
                    "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (askResult == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                else 
                {
                    var settingItem = _webClient.CreateInputSetting();
                    settingItem.Name = txt_SettingName.Text.Trim();
                    settings[txt_SettingName.Text.Trim()] = settingItem;
                }
            }
            else
            {
                var settingItem = _webClient.CreateInputSetting();
                settingItem.Name = txt_SettingName.Text.Trim();
                settings.Add(settingItem.Name, settingItem);
            }
            SettingNamager.WirteSettings();

            MessageBox.Show("Success!");
        }
    }
}
