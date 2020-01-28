namespace WebSocketClient
{
    partial class SaveInputWindow
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
            this.btm_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SettingName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btm_save
            // 
            this.btm_save.Location = new System.Drawing.Point(41, 113);
            this.btm_save.Name = "btm_save";
            this.btm_save.Size = new System.Drawing.Size(75, 21);
            this.btm_save.TabIndex = 0;
            this.btm_save.Text = "Save";
            this.btm_save.UseVisualStyleBackColor = true;
            this.btm_save.Click += new System.EventHandler(this.btm_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(203, 113);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 21);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Setting Name";
            // 
            // txt_SettingName
            // 
            this.txt_SettingName.Location = new System.Drawing.Point(41, 61);
            this.txt_SettingName.Name = "txt_SettingName";
            this.txt_SettingName.Size = new System.Drawing.Size(237, 21);
            this.txt_SettingName.TabIndex = 3;
            // 
            // SaveInputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 156);
            this.Controls.Add(this.txt_SettingName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btm_save);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 195);
            this.Name = "SaveInputWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveInputWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SettingName;
    }
}