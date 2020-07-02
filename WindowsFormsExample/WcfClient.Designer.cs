namespace WindowsFormsExample {
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
            this.btnCallService = new System.Windows.Forms.Button();
            this.btnCallServiceFluent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallService
            // 
            this.btnCallService.Location = new System.Drawing.Point(230, 175);
            this.btnCallService.Name = "btnCallService";
            this.btnCallService.Size = new System.Drawing.Size(237, 26);
            this.btnCallService.TabIndex = 0;
            this.btnCallService.Text = "Call Service";
            this.btnCallService.UseVisualStyleBackColor = true;
            this.btnCallService.Click += new System.EventHandler(this.btnCallService_Click);
            // 
            // btnCallServiceFluent
            // 
            this.btnCallServiceFluent.Location = new System.Drawing.Point(230, 219);
            this.btnCallServiceFluent.Name = "btnCallServiceFluent";
            this.btnCallServiceFluent.Size = new System.Drawing.Size(237, 26);
            this.btnCallServiceFluent.TabIndex = 1;
            this.btnCallServiceFluent.Text = "Call Service Using Fluent Connection";
            this.btnCallServiceFluent.UseVisualStyleBackColor = true;
            this.btnCallServiceFluent.Click += new System.EventHandler(this.btnCallServiceFluent_Click);
            // 
            // WcfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCallServiceFluent);
            this.Controls.Add(this.btnCallService);
            this.Name = "WcfClient";
            this.Text = "WcfClient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallService;
        private System.Windows.Forms.Button btnCallServiceFluent;
    }
}