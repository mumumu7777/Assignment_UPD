using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_MaintainUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private userIndexValue TocategoryVM(DataRow row)
        {
            return new userIndexValue
            {
                name = row.Field<string>("name"),
                height = row.Field<int>("height"),
                account = row.Field<string>("account"),
                password = row.Field<string>("Categoryname"),

            };
        }
    }
}
