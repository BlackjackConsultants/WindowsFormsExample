using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpExamples {
    public partial class JsonExamples : Form {
        public JsonExamples() {
            InitializeComponent();
        }

        private void lstCreateJson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Contact test = new Contact();
            test.Name = "Lucre";
            var objStr = JsonConvert.SerializeObject(test);
            System.Diagnostics.Debug.WriteLine(objStr);
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


        private void lstJsonReport_FilterReport(object sender, LinkLabelLinkClickedEventArgs e) {
            // creating json and parsing it
            string json = @"{'results': [{'buttonPress': 8, 'minutesStreamed': 83 }, { 'buttonPress': 3, 'minutesStreamed': 4 }, {'buttonPress': 7, 'minutesStreamed': 61 }]}";
            JObject obj = JObject.Parse(json);
            var list = obj["results"]
                        .Where(r => (int)r["minutesStreamed"] > 60);

            System.Diagnostics.Debug.WriteLine(list.Count().ToString());

            // using jobjects and querying ints
            var report = new JArray(
                        new JObject(
                            new JProperty("title", "a"),
                            new JProperty("amount", 8),
                            new JProperty("description", "James Newton-King's blog.")));

            report.Add(new JObject(
                            new JProperty("title", "b"),
                            new JProperty("amount", 9),
                            new JProperty("description", "James Newton-King's blog.")));
            var test = report.Where(r => (int)r["amount"] == 9);
            System.Diagnostics.Debug.WriteLine(test.Count().ToString());

            // using jobjects and querying ints
            var report2 = new JArray(
                        new JObject(
                            new JProperty("title", "a"),
                            new JProperty("amount", 8),
                            new JProperty("description", "James Newton-King's blog.")));

            report2.Add(new JObject(
                            new JProperty("title", "b"),
                            new JProperty("amount", 9),
                            new JProperty("description", "James Newton-King's blog.")));
            var test2 = report2.Where(r => r["title"].ToString() == "b").ToList();
            //System.Diagnostics.Debug.WriteLine(test2.Count().ToString());
            System.Diagnostics.Debug.WriteLine("the value for the filtered title is: " + test2[0]["title"]);



        }
    }
}
