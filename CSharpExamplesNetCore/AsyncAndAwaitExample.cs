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
            System.Diagnostics.Debug.WriteLine("Before runProcess() in the button.");
            Task<int> task = RunProcess();
            int count = await task;
            textBox1.Text = count.ToString();
            System.Diagnostics.Debug.WriteLine(count.ToString() + " after RunProcesss() in the button.");
        }

        private async void callMethod() {
            var id = await RunProcess();

        }


        static async Task<int> RunProcess() {
            var count = 0;
            await Task.Run(async () => {
                System.Diagnostics.Debug.WriteLine("before sleep. " + count.ToString());
                await Task.Delay(4000);
                count = 1;
                System.Diagnostics.Debug.WriteLine("after sleep. " + count.ToString());
            });
            System.Diagnostics.Debug.WriteLine(" in the RunProcess. " + count.ToString());
            return count;
        }

    }
}
