namespace CSharpExamplesNetCore {
    partial class ConfigurationExample {
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
            this.btnGetConfigSection = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGetConfigSection
            // 
            this.btnGetConfigSection.AutoSize = true;
            this.btnGetConfigSection.Location = new System.Drawing.Point(275, 198);
            this.btnGetConfigSection.Name = "btnGetConfigSection";
            this.btnGetConfigSection.Size = new System.Drawing.Size(158, 15);
            this.btnGetConfigSection.TabIndex = 0;
            this.btnGetConfigSection.TabStop = true;
            this.btnGetConfigSection.Text = "Get Section From Config File";
            this.btnGetConfigSection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGetConfigSection_LinkClicked);
            // 
            // ConfigurationExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetConfigSection);
            this.Name = "ConfigurationExample";
            this.Text = "ConfigurationExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel btnGetConfigSection;
    }
}