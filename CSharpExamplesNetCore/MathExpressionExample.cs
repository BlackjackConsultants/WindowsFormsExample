using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExamples {
    public partial class MathExpressionExample : Form {
        private List<string> snippets = new List<string>();

        public MathExpressionExample() {
            InitializeComponent();
            LoadCodeSnippets();
            LoadListBox();
        }

        private void LoadListBox()
        {
            foreach (var item in snippets)
            {
                listBox1.Items.Add(item);
            }
        }

        private void LoadCodeSnippets()
        {
            snippets.Add("var c = 1;");
            snippets.Add("var c = \"testing\";");
            snippets.Add("var c = (true) ? (false) ? 1 : 2 : 3;");
        }

        private void btnSubmit_Click(object sender, EventArgs e)         {
            var result = CSharpScript.EvaluateAsync(txtExpression.Text).Result.ToString();
            txtResult.Text = result;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            ScriptState state = CSharpScript.RunAsync(txtScript.Text).Result;
            var value = state.GetVariable("c");
            txtResult.Text = value.Value.ToString();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            txtScript.Text = listBox1.SelectedItem.ToString();
        }
    }
}
