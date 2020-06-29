namespace CSharpExamples {
    partial class WcfClient {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lnkCallService = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkCallService
            // 
            this.lnkCallService.AutoSize = true;
            this.lnkCallService.Location = new System.Drawing.Point(350, 116);
            this.lnkCallService.Name = "lnkCallService";
            this.lnkCallService.Size = new System.Drawing.Size(67, 15);
            this.lnkCallService.TabIndex = 0;
            this.lnkCallService.TabStop = true;
            this.lnkCallService.Text = "Call Service";
            this.lnkCallService.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallService_LinkClicked);
            // 
            // WcfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkCallService);
            this.Name = "WcfClient";
            this.Text = "WcfClient";
            this.Load += new System.EventHandler(this.WcfClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkCallService;
    }
}