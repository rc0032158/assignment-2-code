using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_code
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
        //5 resistors in series
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                
                double r1, r2, r3, r4, r5;

                try
                {
                    r1 = Convert.ToDouble(t1.Text);
                }
                catch
                {
                    r1 = 0;
                }

                try
                {
                    r2 = Convert.ToDouble(t2.Text);
                }
                catch
                {
                    r2 = 0;
                }

                try
                {
                    r3 = Convert.ToDouble(t3.Text);
                }
                catch
                {
                    r3 = 0;
                }


                try
                {
                    r4 = Convert.ToDouble(t4.Text);
                }
                catch
                {
                    r4 = 0;
                }
                //

                try
                {
                    r5 = Convert.ToDouble(t5.Text);
                }
                catch
                {
                    r5 = 0;
                }


                double rt = r1 + r2 + r3 + r4 + r5;

                label4.Text = Convert.ToString(rt);



            }
            else
            {
                double r1, r2, r3, r4, r5;
                double rtr = 0;
                //5 resistors in parallel
                try
                {
                    r1 = Convert.ToDouble(t1.Text);
                    rtr = rtr + 1 / r1;
                }
                catch
                {
                    
                }

                try
                {
                    r2 = Convert.ToDouble(t2.Text);
                    rtr = rtr + 1 / r2;
                }
                catch
                {
                    r2 = 0;
                }

                try
                {
                    r3 = Convert.ToDouble(t3.Text);
                    rtr = rtr + 1 / r3;
                }
                catch
                {
                    r3 = 0;
                }


                try
                {
                    r4 = Convert.ToDouble(t4.Text);
                    rtr = rtr + 1 / r4;
                }
                catch
                {
                    r4 = 0;
                }


                try
                {
                    r5 = Convert.ToDouble(t5.Text);
                    rtr = rtr + 1 / r5;
                }
                catch
                {
                    r5 = 0;
                }


                double rt = 1/rtr;

                label4.Text = Convert.ToString(rt);
            }
        }
    }
}
