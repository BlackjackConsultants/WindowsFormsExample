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
            var report = new JArray(
                        new JObject(
                            new JProperty("title", "James Newton-King"),
                            new JProperty("link", "http://james.newtonking.com"),
                            new JProperty("description", "James Newton-King's blog.")));

            report.Add(new JObject(
                            new JProperty("title", "James Newton-King"),
                            new JProperty("link", "http://james.newtonking.com"),
                            new JProperty("description", "James Newton-King's blog.")));

            System.Diagnostics.Debug.WriteLine(report.ToString());
            System.Diagnostics.Debug.WriteLine(report[0]["title"]);
        }
    }
}
