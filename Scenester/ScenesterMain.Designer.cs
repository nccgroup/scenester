namespace Scenester
{
    partial class ScenesterMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScenesterMain));
            this.run_btn = new System.Windows.Forms.Button();
            this.urlip_grpbox = new System.Windows.Forms.GroupBox();
            this.urlIp_txtarea = new System.Windows.Forms.TextBox();
            this.userAgent_grpbox = new System.Windows.Forms.GroupBox();
            this.https_rbtn = new System.Windows.Forms.RadioButton();
            this.http_rbtn = new System.Windows.Forms.RadioButton();
            this.importUseragent_txt = new System.Windows.Forms.TextBox();
            this.importUseragent_btn = new System.Windows.Forms.Button();
            this.userAgent_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorMsg_txt = new System.Windows.Forms.TextBox();
            this.importUseragentXml_fdb = new System.Windows.Forms.OpenFileDialog();
            this.screenshot_progressbar = new System.Windows.Forms.ProgressBar();
            this.progress_lbl = new System.Windows.Forms.Label();
            this.urlip_grpbox.SuspendLayout();
            this.userAgent_grpbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // run_btn
            // 
            this.run_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.run_btn.Location = new System.Drawing.Point(232, 752);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(126, 38);
            this.run_btn.TabIndex = 0;
            this.run_btn.Text = "Run";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // urlip_grpbox
            // 
            this.urlip_grpbox.Controls.Add(this.urlIp_txtarea);
            this.urlip_grpbox.Location = new System.Drawing.Point(12, 13);
            this.urlip_grpbox.Name = "urlip_grpbox";
            this.urlip_grpbox.Size = new System.Drawing.Size(587, 199);
            this.urlip_grpbox.TabIndex = 1;
            this.urlip_grpbox.TabStop = false;
            this.urlip_grpbox.Text = "URL/IPs";
            // 
            // urlIp_txtarea
            // 
            this.urlIp_txtarea.Location = new System.Drawing.Point(7, 23);
            this.urlIp_txtarea.Multiline = true;
            this.urlIp_txtarea.Name = "urlIp_txtarea";
            this.urlIp_txtarea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.urlIp_txtarea.Size = new System.Drawing.Size(574, 169);
            this.urlIp_txtarea.TabIndex = 0;
            // 
            // userAgent_grpbox
            // 
            this.userAgent_grpbox.Controls.Add(this.https_rbtn);
            this.userAgent_grpbox.Controls.Add(this.http_rbtn);
            this.userAgent_grpbox.Controls.Add(this.importUseragent_txt);
            this.userAgent_grpbox.Controls.Add(this.importUseragent_btn);
            this.userAgent_grpbox.Controls.Add(this.userAgent_listbox);
            this.userAgent_grpbox.Location = new System.Drawing.Point(13, 218);
            this.userAgent_grpbox.Name = "userAgent_grpbox";
            this.userAgent_grpbox.Size = new System.Drawing.Size(586, 313);
            this.userAgent_grpbox.TabIndex = 2;
            this.userAgent_grpbox.TabStop = false;
            this.userAgent_grpbox.Text = "User Agents List";
            // 
            // https_rbtn
            // 
            this.https_rbtn.AutoSize = true;
            this.https_rbtn.Location = new System.Drawing.Point(83, 271);
            this.https_rbtn.Name = "https_rbtn";
            this.https_rbtn.Size = new System.Drawing.Size(75, 21);
            this.https_rbtn.TabIndex = 4;
            this.https_rbtn.TabStop = true;
            this.https_rbtn.Text = "HTTPS";
            this.https_rbtn.UseVisualStyleBackColor = true;
            // 
            // http_rbtn
            // 
            this.http_rbtn.AutoSize = true;
            this.http_rbtn.Checked = true;
            this.http_rbtn.Location = new System.Drawing.Point(11, 271);
            this.http_rbtn.Name = "http_rbtn";
            this.http_rbtn.Size = new System.Drawing.Size(66, 21);
            this.http_rbtn.TabIndex = 3;
            this.http_rbtn.TabStop = true;
            this.http_rbtn.Text = "HTTP";
            this.http_rbtn.UseVisualStyleBackColor = true;
            // 
            // importUseragent_txt
            // 
            this.importUseragent_txt.Enabled = false;
            this.importUseragent_txt.Location = new System.Drawing.Point(11, 26);
            this.importUseragent_txt.Name = "importUseragent_txt";
            this.importUseragent_txt.Size = new System.Drawing.Size(488, 23);
            this.importUseragent_txt.TabIndex = 2;
            // 
            // importUseragent_btn
            // 
            this.importUseragent_btn.Location = new System.Drawing.Point(505, 26);
            this.importUseragent_btn.Name = "importUseragent_btn";
            this.importUseragent_btn.Size = new System.Drawing.Size(75, 24);
            this.importUseragent_btn.TabIndex = 1;
            this.importUseragent_btn.Text = "Import";
            this.importUseragent_btn.UseVisualStyleBackColor = true;
            this.importUseragent_btn.Click += new System.EventHandler(this.importUseragent_btn_Click);
            // 
            // userAgent_listbox
            // 
            this.userAgent_listbox.FormattingEnabled = true;
            this.userAgent_listbox.ItemHeight = 17;
            this.userAgent_listbox.Location = new System.Drawing.Point(6, 56);
            this.userAgent_listbox.Name = "userAgent_listbox";
            this.userAgent_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.userAgent_listbox.Size = new System.Drawing.Size(574, 208);
            this.userAgent_listbox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMsg_txt);
            this.groupBox1.Location = new System.Drawing.Point(13, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Error Logs";
            // 
            // errorMsg_txt
            // 
            this.errorMsg_txt.Location = new System.Drawing.Point(6, 36);
            this.errorMsg_txt.Multiline = true;
            this.errorMsg_txt.Name = "errorMsg_txt";
            this.errorMsg_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errorMsg_txt.Size = new System.Drawing.Size(574, 86);
            this.errorMsg_txt.TabIndex = 0;
            // 
            // importUseragentXml_fdb
            // 
            this.importUseragentXml_fdb.FileName = "Import UserAgent XML";
            // 
            // screenshot_progressbar
            // 
            this.screenshot_progressbar.Location = new System.Drawing.Point(19, 691);
            this.screenshot_progressbar.Name = "screenshot_progressbar";
            this.screenshot_progressbar.Size = new System.Drawing.Size(574, 23);
            this.screenshot_progressbar.TabIndex = 4;
            // 
            // progress_lbl
            // 
            this.progress_lbl.AutoSize = true;
            this.progress_lbl.Location = new System.Drawing.Point(16, 717);
            this.progress_lbl.Name = "progress_lbl";
            this.progress_lbl.Size = new System.Drawing.Size(114, 17);
            this.progress_lbl.TabIndex = 5;
            this.progress_lbl.Text = "Total :  0/0 Done";
            // 
            // ScenesterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 821);
            this.Controls.Add(this.progress_lbl);
            this.Controls.Add(this.screenshot_progressbar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userAgent_grpbox);
            this.Controls.Add(this.urlip_grpbox);
            this.Controls.Add(this.run_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScenesterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scenester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.urlip_grpbox.ResumeLayout(false);
            this.urlip_grpbox.PerformLayout();
            this.userAgent_grpbox.ResumeLayout(false);
            this.userAgent_grpbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.GroupBox urlip_grpbox;
        private System.Windows.Forms.TextBox urlIp_txtarea;
        private System.Windows.Forms.GroupBox userAgent_grpbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox errorMsg_txt;
        private System.Windows.Forms.ListBox userAgent_listbox;
        private System.Windows.Forms.TextBox importUseragent_txt;
        private System.Windows.Forms.Button importUseragent_btn;
        private System.Windows.Forms.OpenFileDialog importUseragentXml_fdb;
        private System.Windows.Forms.RadioButton https_rbtn;
        private System.Windows.Forms.RadioButton http_rbtn;
        private System.Windows.Forms.ProgressBar screenshot_progressbar;
        private System.Windows.Forms.Label progress_lbl;
    }
}

