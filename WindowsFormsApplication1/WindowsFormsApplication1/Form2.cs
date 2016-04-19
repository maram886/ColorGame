using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2(String s)
        {
            InitializeComponent();
            label1.Text = label1.Text+" "+s;
   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Click(object sender, EventArgs e)
        {
            int win;
            int lose;
            int sum;
           
                sum = Convert.ToInt32(label10.Text) + Convert.ToInt32(label11.Text);
                if (sum == Convert.ToInt32(textBox1.Text))
                {
                    win = Convert.ToInt32(label8.Text) + 1;
                    label8.Text = win + "";
                }
                else
                {
                    lose = Convert.ToInt32(label9.Text) + 1;
                    label9.Text = lose + "";
                }
                Random RandomSpeed = new Random();
                int rand = RandomSpeed.Next(1, 5);
                label10.Text = rand.ToString();
                label11.Text = rand.ToString();
                label10.Refresh();
                label11.Refresh();
             
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
