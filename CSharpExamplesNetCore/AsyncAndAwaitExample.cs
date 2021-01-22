using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExamplesNetCore {
    public partial class AsyncAndAwaitExample : Form {
        public AsyncAndAwaitExample() {
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e) {
            Task<int> task = RunProcess();
            int count = await task;
            textBox1.Text = count.ToString();
        }

        private async void callMethod() {
            var id = await RunProcess();

        }


        static async Task<int> RunProcess() {
            Task.Run(() => {
                Thread.Sleep(10000);
            });
            return 1;
        }

    }
}
