﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exec2_meassage
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("你好現在時間yyyy/MM/dd/' 'hh:mm:ss");
			MessageBox.Show(label1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label2.Text = DateTime.Now.ToString("你好現在時間yyyy/MM/dd/' 'hh:mm:ss");
		}
	}
}