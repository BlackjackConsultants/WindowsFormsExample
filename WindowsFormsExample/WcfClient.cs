using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample {
    public partial class WcfClient : Form {
        public WcfClient() {
            InitializeComponent();
        }

        private void btnCallService_Click(object sender, EventArgs e) {
            var applicationSettings = (System.ServiceModel.Configuration.BindingsSection)ConfigurationManager.GetSection("system.serviceModel/bindings");
            if (applicationSettings.WSHttpBinding.Bindings.Count > 0) {
                throw new Exception("You need to uncomment the the system.serviceModel section of the app.config file so we can test .config type configuation.");
            }
            CSharpExamples.SimpleService.SimpleServiceClient client = new CSharpExamples.SimpleService.SimpleServiceClient();
            MessageBox.Show(client.GetUserName());
        }

        private void btnCallServiceFluent_Click(object sender, EventArgs e) {
            var applicationSettings = (BindingsSection)ConfigurationManager.GetSection("system.serviceModel/bindings");
            if (applicationSettings.WSHttpBinding.Bindings.Count>0) {
                throw new Exception("You need to comment the system.serviceModel section of the app.config file so we can test Fluent configuation.");
            }
            
            Console.WriteLine("");
        }
    }
}
