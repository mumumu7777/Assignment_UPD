using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
			int maleprice = malesfee();
			int femaleprice = femalesfee();
			if (Age < 3)
			{
                ticketfee.Text = "0元";
                 resonlabel.Text = "兒童票";
            }




            //else ticketfee.Text = "15元"; resonlabel.Text = "全票";


            //else if (Age > 3 && Age < 70 && malebtm.Checked)
            //{
            //	ticketfee.Text = "15元";
            //	resonlabel.Text = "全票";
            //}

            //else if (Age > 3 && Age < 60 && femalebtm.Checked)
            //{
            //             ticketfee.Text = "15元";
            //             resonlabel.Text = "全票";

            //         }

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

		private int malesfee()
		{
			int maleage = AGEENSURE();
			if (malebtm.Checked && maleage >= 70)
			{
				ticketfee.Text = "2元";
				resonlabel.Text = "先生您的年紀符合優惠";

			}
			else { ticketfee.Text = "15元"; resonlabel.Text = "全票"; }
			return maleage;
        }

		private int femalesfee()
		{
			int femaleage = AGEENSURE();
            if (femalebtm.Checked && femaleage >= 60)
            {
                ticketfee.Text = "3元";
                resonlabel.Text = "女士您的年紀符合優惠";
            }
            else { ticketfee.Text = "15元"; resonlabel.Text = "全票"; }
            return femaleage;
        }
		
	}
}
