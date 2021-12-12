using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glorious_app_by__Ghenghea_Andrei
{
    public partial class Form1 : Form
    {
        private int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            int s = 0;
            while (num != 0)
            {
                s += num % 10;
                num /= 10;
            }

            textBox2.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            int cmax = 0;
            while (num != 0)
            {
                if(cmax < num % 10)
                {
                    cmax = num % 10;
                }
                num /= 10;
            }
            textBox2.Text = Convert.ToString(cmax);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            int rev = 0;

            while (num != 0)
            {
                rev += num % 10;
                rev *= 10;
                num /= 10;
            }

            textBox2.Text = Convert.ToString(rev / 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = int.Parse(textBox1.Text);

            textBox2.Text = Convert.ToString(Convert.ToString(num, 2));
        }
    }
}
