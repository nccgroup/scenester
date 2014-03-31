namespace Scenester
{
    partial class About
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
            this.About_ico = new System.Windows.Forms.PictureBox();
            this.aboutTitle_lbl = new System.Windows.Forms.Label();
            this.aboutVersion_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.about_releaseUnder_lbl = new System.Windows.Forms.Label();
            this.nccGroup_linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.About_ico)).BeginInit();
            this.SuspendLayout();
            // 
            // About_ico
            // 
            this.About_ico.ErrorImage = global::Scenester.Properties.Resources.About_Img;
            this.About_ico.Image = global::Scenester.Properties.Resources.About_Img;
            this.About_ico.Location = new System.Drawing.Point(13, 9);
            this.About_ico.Name = "About_ico";
            this.About_ico.Size = new System.Drawing.Size(100, 100);
            this.About_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.About_ico.TabIndex = 0;
            this.About_ico.TabStop = false;
            // 
            // aboutTitle_lbl
            // 
            this.aboutTitle_lbl.AutoSize = true;
            this.aboutTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutTitle_lbl.Location = new System.Drawing.Point(119, 9);
            this.aboutTitle_lbl.Name = "aboutTitle_lbl";
            this.aboutTitle_lbl.Size = new System.Drawing.Size(209, 46);
            this.aboutTitle_lbl.TabIndex = 1;
            this.aboutTitle_lbl.Text = "Scenester";
            // 
            // aboutVersion_lbl
            // 
            this.aboutVersion_lbl.AutoSize = true;
            this.aboutVersion_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutVersion_lbl.Location = new System.Drawing.Point(124, 55);
            this.aboutVersion_lbl.Name = "aboutVersion_lbl";
            this.aboutVersion_lbl.Size = new System.Drawing.Size(84, 17);
            this.aboutVersion_lbl.TabIndex = 2;
            this.aboutVersion_lbl.Text = "Version: 1.0";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(493, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // about_releaseUnder_lbl
            // 
            this.about_releaseUnder_lbl.AutoSize = true;
            this.about_releaseUnder_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.about_releaseUnder_lbl.Location = new System.Drawing.Point(124, 81);
            this.about_releaseUnder_lbl.Name = "about_releaseUnder_lbl";
            this.about_releaseUnder_lbl.Size = new System.Drawing.Size(301, 17);
            this.about_releaseUnder_lbl.TabIndex = 4;
            this.about_releaseUnder_lbl.Text = "Released as open source by NCC Group Plc - ";
            // 
            // nccGroup_linkLabel
            // 
            this.nccGroup_linkLabel.AutoSize = true;
            this.nccGroup_linkLabel.Location = new System.Drawing.Point(417, 81);
            this.nccGroup_linkLabel.Name = "nccGroup_linkLabel";
            this.nccGroup_linkLabel.Size = new System.Drawing.Size(168, 17);
            this.nccGroup_linkLabel.TabIndex = 5;
            this.nccGroup_linkLabel.TabStop = true;
            this.nccGroup_linkLabel.Text = "http://www.nccgroup.com/";
            this.nccGroup_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nccGroup_linkLabel_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 160);
            this.Controls.Add(this.nccGroup_linkLabel);
            this.Controls.Add(this.about_releaseUnder_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aboutVersion_lbl);
            this.Controls.Add(this.aboutTitle_lbl);
            this.Controls.Add(this.About_ico);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.About_ico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox About_ico;
        private System.Windows.Forms.Label aboutTitle_lbl;
        private System.Windows.Forms.Label aboutVersion_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label about_releaseUnder_lbl;
        private System.Windows.Forms.LinkLabel nccGroup_linkLabel;
    }
}