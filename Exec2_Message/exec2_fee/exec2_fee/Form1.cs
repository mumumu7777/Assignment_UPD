using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exec2_fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void searchbtm_Click(object sender, EventArgs e)
		{
			int Age = AGEENSURE();

			if (malebtm.Checked && Age <= 70)

			{
				ticketfee.Text = "2元";
			}
			else if (femalebtm.Checked && Age <= 60)
			{
				ticketfee.Text = "3元";
			}					
		}
		private void malebtm_CheckedChanged(object sender, EventArgs e)
		{	

		}

		private void femalebtm_CheckedChanged(object sender, EventArgs e)
		{

		}


		private int AGEENSURE()
		{

			bool isint = int.TryParse(textBox1.Text, out int trueage);
			if (isint == false || trueage < 0 || trueage > 150)
			{ MessageBox.Show("請填入正確年紀"); }			
				return trueage;
		}

		//private string Gender()
		//{	
		//			    		
		//}
		//private string pricecalc()
		//{
		//		
		//}
		
	}
}
