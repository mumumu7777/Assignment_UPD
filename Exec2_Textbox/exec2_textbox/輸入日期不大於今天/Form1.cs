using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 輸入日期不大於今天
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime dayinput = Convert.ToDateTime(textBox1.Text);
			if (DateTime.Today < dayinput)
			{ MessageBox.Show("日期大於今天"); }
			else { MessageBox.Show("日期小於今天"); }
		}
	}
}
