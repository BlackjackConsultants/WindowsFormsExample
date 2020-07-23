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
        public MathExpressionExample() {
            InitializeComponent();
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
    }
}
