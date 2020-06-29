using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample {
    public partial class WcfClient : Form {
        public WcfClient() {
            InitializeComponent();
        }

        private void btnCallService_Click(object sender, EventArgs e) {
            SimpleService.SimpleServiceClient client = new SimpleService.SimpleServiceClient();
            MessageBox.Show(client.GetUserName());
        }
    }
}
