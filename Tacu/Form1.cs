using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tacu
{
    public partial class Form1 : Form
    {
        public int number;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);

            int s = 0;
            while(number != 0)
            {
                s += number % 10;
                number /= 10;
            }
            textBox2.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);

            textBox2.Text = Convert.ToString(Convert.ToString(number, 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);

            int cmax = 0;

            while (number != 0)
            {
                if(cmax <= number % 10)
                {
                    cmax = number % 10;
                }
                number /= 10;
            }
            textBox2.Text = Convert.ToString(cmax);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            number = Convert.ToInt32(textBox1.Text);

            int rev = 0;

            while(number != 0)
            {
                rev += number % 10;
                rev *= 10;
                number /= 10;
            }

            textBox2.Text = Convert.ToString(rev / 10);
        }
    }
}
