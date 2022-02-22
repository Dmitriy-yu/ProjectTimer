using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTimer
{
    public partial class Form1 : Form
    {
        
        int h, m, s;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s==-1)
            {
                s = 59;
                m = m - 1;
            }
            if (m==-1)
            {
                m = 59;
                h = -1;
            }
            if (h == 0 && m == 0&&s == 0)
            {
                MessageBox.Show ("Время вышло","Что произошло",MessageBoxButtons.OK);
                
                timer1.Stop();

            }
            
            else
            {
                label1.Text = "0";
                label2.Text = "0";
                label5.Text = "0";

            }

            label1.Text = Convert.ToString(m);
            label2.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "0";
            label2.Text = "0";
            label5.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
             h = Convert.ToInt32(textBox1.Text);
             m = Convert.ToInt32(textBox2.Text);
             s = Convert.ToInt32(textBox3.Text);
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

      

    }
}
