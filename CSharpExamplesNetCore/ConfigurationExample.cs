using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpExamplesNetCore {
    public partial class ConfigurationExample : Form {
        public ConfigurationExample() {
            InitializeComponent();
        }

        private void btnGetConfigSection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // check to see if the app.config has configured the wcf. if it does, then ask user to comment it out.

        }
    }
}
