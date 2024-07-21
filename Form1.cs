using System;

namespace CSharp_GiaiPTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = Convert.ToDouble (SoA.Text);
            b = Convert.ToDouble (soB.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    KetQua.Text = ("Phương trình có vô số nghiệm".ToString());
                }
                else
                {
                    KetQua.Text = ("Phương trình vô nghiệm".ToString());
                }
            }
            else
            {
                x = (double)-b / a;
                KetQua.Text = ("Phương trình có nghiệm là : " + x.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
