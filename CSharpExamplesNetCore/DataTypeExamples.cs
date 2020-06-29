using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpExamples {
    public partial class DataTypeExamples : Form {
        public DataTypeExamples() {
            InitializeComponent();
        }

        private void lstJsonReport_AddReport(object sender, LinkLabelLinkClickedEventArgs e) {
            string data = "\"test\"";
            System.Diagnostics.Debug.WriteLine(data);
            string data1 = @"""test""";
            System.Diagnostics.Debug.WriteLine(data1);
            string data3 = data1.Replace(@"\""", "\"");
            System.Diagnostics.Debug.WriteLine(data3);
            
        }
    }
}
