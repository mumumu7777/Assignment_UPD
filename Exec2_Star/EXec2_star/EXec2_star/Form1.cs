using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXec2_star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void printbuttom_Click(object sender, EventArgs e)
		{
			//取得數字[1,10]
			int? inputint = Catchuserinput();
			if (inputint.HasValue == false)
			{
				MessageBox.Show("請輸入數值");
				return;
			}
			if (inputint.Value > 10 || inputint.Value <= 0)

			{
				MessageBox.Show("數值必須在1~10之間");
				return;
			}
			//show stars

			string stars = Showstars(inputint.Value)+Showeqstars(inputint.Value)+Showrightstars(inputint.Value);
			
			starBox.Text = stars;
		}






		private int? Catchuserinput()
		{
			string input = userinputBox.Text;
			bool isint = int.TryParse(input, out int inputint);
			if (isint)
			{
				return inputint;
			}
			else return null;
		}
		private string Showstars(int inputint)
		{
			string result = string.Empty;
			for (int i = 1; i <= inputint; i++)
			{
				result += new string('*', i) + "\r\n";

			}
			return result;		
		}
		private string Showeqstars(int inputint)
		{
			string result = string.Empty;
			for (int j = 1; j <= inputint; j++)
			{
				string space = new string(' ', inputint-j  );
				string stars = new string('*', 2 * j- 1);
				result += space+stars +"\r\n";
			}
			return result;
		}
		private string Showrightstars(int inputint)
		{
			string result = string.Empty;
			for (int k = 1; k <= inputint; k++)
			{
				string space = new string(' ', inputint-k);
				string stars = new string('*', k-1);
				result += space +stars + "\r\n";

			}
			return result;
		}


	}


}

