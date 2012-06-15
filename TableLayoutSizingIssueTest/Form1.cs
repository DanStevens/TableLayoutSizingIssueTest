using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TableLayoutSizingIssueTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelFieldSize.Text = comboField.Size.Width.ToString();
		}

		private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
		{
			labelFieldSize.Text = comboField.Size.Width.ToString();
		}
	}
}
