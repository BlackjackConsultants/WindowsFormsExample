namespace CSharpExamples {
    partial class JsonExamples {
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
            this.lstJsonReport = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lstJsonReport
            // 
            this.lstJsonReport.AutoSize = true;
            this.lstJsonReport.Location = new System.Drawing.Point(249, 241);
            this.lstJsonReport.Name = "lstJsonReport";
            this.lstJsonReport.Size = new System.Drawing.Size(105, 15);
            this.lstJsonReport.TabIndex = 0;
            this.lstJsonReport.TabStop = true;
            this.lstJsonReport.Text = "Create Json Report";
            this.lstJsonReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lstJsonReport_LinkClicked);
            // 
            // JsonExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstJsonReport);
            this.Name = "JsonExamples";
            this.Text = "JsonExamples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lstJsonReport;
    }
}