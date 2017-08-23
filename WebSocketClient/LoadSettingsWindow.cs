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
    public partial class LoadSettingsWindow : Form
    {
        WebSocketTestClient _webClient;
        public LoadSettingsWindow(WebSocketTestClient webClient)
        {
            InitializeComponent();
            _webClient = webClient;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;

            if (cmb_Settings.SelectedItem != null)
            {
                InputSetting setting = (InputSetting)cmb_Settings.SelectedItem;

                _webClient.PutSettings(setting);

                dialogResult = MessageBox.Show("Setting was load!");
            }
            else
            {
                dialogResult = MessageBox.Show("Please select one setting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void LoadSettingsWindow_Load(object sender, EventArgs e)
        {
            var settings = SettingNamager.Instance.GetSettingList();
            var autoSource = new AutoCompleteStringCollection();

            cmb_Settings.Items.Clear();
            foreach (var item in settings)
            {
                cmb_Settings.Items.Add(item.Value);
                autoSource.Add(item.Key);
            }

            cmb_Settings.AutoCompleteCustomSource = autoSource;
        }
    }
}
