namespace WebSocketClient
{
    partial class LoadSettingsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Settings = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting Name:";
            // 
            // cmb_Settings
            // 
            this.cmb_Settings.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "ad",
            "asdf",
            "aaa"});
            this.cmb_Settings.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Settings.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmb_Settings.FormattingEnabled = true;
            this.cmb_Settings.Location = new System.Drawing.Point(101, 64);
            this.cmb_Settings.Name = "cmb_Settings";
            this.cmb_Settings.Size = new System.Drawing.Size(194, 21);
            this.cmb_Settings.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(321, 64);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // LoadSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 141);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cmb_Settings);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadSettingsWindow";
            this.Text = "LoadSettingsWindow";
            this.Load += new System.EventHandler(this.LoadSettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Settings;
        private System.Windows.Forms.Button btn_load;
    }
}