using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exec2_textbox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            string mess = "請重新輸入1~99數值";
            if (input >= 1 && input <= 99)
            {
                MessageBox.Show("數值在一至九九內");
            }

            else { MessageBox.Show(mess, "錯誤", MessageBoxButtons.YesNo, MessageBoxIcon.Error); }
        }
    }
}
