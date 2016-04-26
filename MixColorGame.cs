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
    public partial class MixColorGame : Form
    {
        public MixColorGame()
        {
            InitializeComponent();
        }

        private void MixColorGame_Load(object sender, EventArgs e)
        {
          


         }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       
        private void button7_Click(object sender, EventArgs e)
        {

            //yellow from group1 with group2 colors
            if ((radioButton1.Checked) && (radioButton5.Checked))
            {
                button8.BackColor = Color.Red; label6.Text = "أحمر"; label6.ForeColor = Color.Red;
            }
             else if ((radioButton1.Checked) && (radioButton6.Checked)){
                 button8.BackColor = Color.Orange; label6.Text = "برتقالي"; label6.ForeColor = Color.Orange;
             }
            else if ((radioButton1.Checked) && (radioButton7.Checked)){
                button8.BackColor = Color.Purple; label6.Text = "بنفسجي"; label6.ForeColor = Color.Purple;
            }
            else if ((radioButton1.Checked) && (radioButton8.Checked)) {
                button8.BackColor = Color.Pink; label6.Text = "وردي"; label6.ForeColor = Color.Pink;
            }
          
                //yellow from group1 with group2 colors
            if ((radioButton2.Checked) && (radioButton5.Checked)){
                button8.BackColor = Color.Orange; label6.Text = "برتقالي"; label6.ForeColor = Color.Orange;
            }
            else if ((radioButton2.Checked) && (radioButton6.Checked)){
                button8.BackColor = Color.Yellow; label6.Text = "أصفر"; label6.ForeColor = Color.Yellow;
            }
            else if ((radioButton2.Checked) && (radioButton7.Checked)){
                button8.BackColor = Color.Green; label6.Text = "أخضر"; label6.ForeColor = Color.Green;
            }
            else if ((radioButton2.Checked) && (radioButton8.Checked)){
                button8.BackColor = Color.Khaki; label6.Text = "أصفر فاتح"; label6.ForeColor = Color.Khaki;
            }
            //blue from group1 with group2 colors
            if ((radioButton3.Checked) && (radioButton5.Checked)){
                button8.BackColor = Color.Purple; label6.Text = "بنفسجي"; label6.ForeColor = Color.Red;
            }
            else if ((radioButton3.Checked) && (radioButton6.Checked)){
                button8.BackColor = Color.Green; label6.Text = "أخضر"; label6.ForeColor = Color.Red;
            }
            else if ((radioButton3.Checked) && (radioButton7.Checked)){
                button8.BackColor = Color.Blue; label6.Text = "أزرق"; label6.ForeColor = Color.Blue;
            }
            else if ((radioButton3.Checked) && (radioButton8.Checked)){
                button8.BackColor = Color.SkyBlue; label6.Text = "سماوي"; label6.ForeColor = Color.SkyBlue;
            }
            //white from group1 with group2 colors
            if ((radioButton4.Checked) && (radioButton5.Checked)){
                button8.BackColor = Color.Pink; label6.Text = "وردي"; label6.ForeColor = Color.Pink;
            }
            else if ((radioButton4.Checked) && (radioButton6.Checked)){
                button8.BackColor = Color.Khaki; label6.Text = "أصفر فاتح"; label6.ForeColor = Color.Khaki;
            }
            else if ((radioButton4.Checked) && (radioButton7.Checked)){
                button8.BackColor = Color.SkyBlue; label6.Text = "سماوي"; label6.ForeColor = Color.SkyBlue;
            }
            else if ((radioButton4.Checked) && (radioButton8.Checked)){
                button8.BackColor = Color.White; label6.Text = "أبيض"; label6.ForeColor = Color.White;
            }
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
          /*  ColorDialog d = new ColorDialog();
            d.ShowDialog();*/
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
                  

        }
        
        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
