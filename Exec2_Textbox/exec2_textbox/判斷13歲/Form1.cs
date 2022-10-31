namespace 判斷13歲
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime input = Convert.ToDateTime(textBox1.Text);
            //TimeSpan ts = DateTime.Now.Subtract(input);
            var age13 = DateTime.Today.AddDays(-13);
            if (age13 > input)
            {
                MessageBox.Show("您已滿十三歲");

            }
            else { MessageBox.Show("您未滿十三歲"); }
            

        }
    }
}