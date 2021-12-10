using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_la_C_Sharp
{
    public partial class Sawcon : Form
    {
        public string operation;
        public int number;

        private int Sum(int num)
        {
            int s = 0;
            while(num != 0)
            {
                s += num % 10;
                num /= 10;
            }
            return s;
        }

        private int Rev(int num)
        {
            int n = 0;
            while(num != 0)
            {
                n += num % 10;
                n *= 10;
                num /= 10;
            }
            return n / 10;
        }

        private string BaseTwo(int num)
        {
            return Convert.ToString(num, 2);
        }

        private int Max(int num)
        {
            int cmax = 0;

            while(num != 0)
            {
                if (cmax < num % 10) cmax = num % 10;
                num /= 10;
            }
            return cmax;
        }

        public Sawcon()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Introduce your number \n");
            }

            if (operation != null)
            {
                switch (operation)
                {
                    case "SUM": textBox2.Text = Convert.ToString(Sum(number));
                        break;
                    case "MAX": textBox2.Text = Convert.ToString(Max(number));
                        break;
                    case "REVERSE": textBox2.Text = Convert.ToString(Rev(number));
                        break;
                    case "BASE 2": textBox2.Text = Convert.ToString(BaseTwo(number));
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select operation");        
            }

            Console.WriteLine(number);
        }
    }
}
