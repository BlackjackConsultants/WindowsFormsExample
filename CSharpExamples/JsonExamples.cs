using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpExamples {
    public partial class JsonExamples : Form {
        public JsonExamples() {
            InitializeComponent();
        }

        private void lstJsonReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var json = "[{\"currency\":\"United States Dollar\",\"exchangeRate\":1,\"amount\":250000.0,\"memoDescription\":\"New as of 6 / 16 / 2020\"},{\"currency\":\"United States Dollar\",\"exchangeRate\":1,\"amount\":250000.0,\"memoDescription\":\"255Characters22X\"}]";
            var test = JsonConvert.DeserializeObject<dynamic>(json);
            for (int i = 0; i < test.Count; i++) {
                string value = test[i]["memoDescription"].ToString();
                System.Diagnostics.Debug.WriteLine(value);
            }
        }
        private void lstJsonReport_AddReport(object sender, LinkLabelLinkClickedEventArgs e) {
            List<JArray> reports = new List<JArray>();
            // add a fake report for deal mapping
            var data = "[" +
              "{" +
               "\"SourceDataId\", \"4\"," +
               "\"SourceDataValue\", \"Australian Dollarv\"," +
               "\"DestinationDataId\", \"43640\"," +
               "\"DestinationDataValue\", \"AP-1-Standalone\"," +
              "}," +
              "{" +
               "\"SourceDataId\", \"3\"," +
               "\"SourceDataValue\", \"UAE Dirham\"," +
               "\"DestinationDataId\", \"43639\"," +
               "\"DestinationDataValue\", \"AP-1-Standalone\"" +
              "}," +
              "{" +
               "\"SourceDataId\", \"1\"," +
               "\"SourceDataValue\", \"United States\"," +
               "\"DestinationDataId\", \"43408\"," +
               "\"DestinationDataValue\", \"AP-1-Standalone\"" +
              "}" +
            "]";
            reports.Add(new JArray(data));
        }
    }
}
