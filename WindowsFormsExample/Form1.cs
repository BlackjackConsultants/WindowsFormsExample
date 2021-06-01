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
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnAddControlInColumn_Click(object sender, EventArgs e) {
			// TableLayoutPanel Initialization
			tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount + 1;
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
			tableLayoutPanel1.Controls.Add(new Label() { Text = "Address", BackColor = Color.CadetBlue, ForeColor = Color.Yellow, Height = 555, AutoSize = false}, 1, 0);
		}

		private void button1_Click(object sender, EventArgs e) {
			// TableLayoutPanel Initialization
			if (txtColumnsCount.Text != string.Empty) {
				tableLayoutPanel1.ColumnCount = Convert.ToInt32(txtColumnsCount.Text);
			}
			else {
				tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount + 1;
			}
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
			tableLayoutPanel1.Controls.Add(new Label() { Text = "Address", BackColor = Color.CadetBlue, ForeColor = Color.Yellow, Height = 555, AutoSize = false }, 1, 0);

		}

		private void button2_Click(object sender, EventArgs e) {
			// TableLayoutPanel Initialization
			if (txtColumnsCount.Text != string.Empty) {
				tableLayoutPanel1.ColumnCount = Convert.ToInt32(txtColumnsCount.Text);
			}
			else {
				tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount + 1;
			}
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
			tableLayoutPanel1.Controls.Add(new Label() { Text = "Address", BackColor = Color.CadetBlue, ForeColor = Color.Yellow, Height = 555, AutoSize = false }, 1, 0);

		}
	}
}
