using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class DrawFR : Form
    {
        bool paint = false;
        SolidBrush color = new SolidBrush(Color.Black);

        Image[] images = new Image[5];
        int i = 0;


        public DrawFR()
        {
            InitializeComponent();
            this.Size = new Size(900, 600);
            button2.Click += new EventHandler(Click);
            button3.Click += new EventHandler(Click);
            button4.Click += new EventHandler(Click);
            button5.Click += new EventHandler(Click);
            button9.Click += new EventHandler(Click);
            button10.Click += new EventHandler(Click);
            button12.Click += new EventHandler(Click);
            button13.Click += new EventHandler(Click);

            images[0] = Properties.Resources.image1;
            images[1] = Properties.Resources.image2;
            images[2] = Properties.Resources.image3;
            images[3] = Properties.Resources.image4;
            images[4] = Properties.Resources.image5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {/*
            Form9 f = new Form9();
            f.Show();
            this.Hide();*/
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //label1.Text = " مرحبا " + Class1.studentname;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد تريد الخروج!؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            //this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                Graphics g1 = panel1.CreateGraphics();
                g1.FillEllipse(color,e.X,e.Y,5,5);
                g1.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* Graphics g2 = panel1.CreateGraphics();
             g2.Clear(panel1.BackColor); */
            panel3.Visible = false;
            panel1.BackgroundImage = Properties.Resources.BG;
            panel1.BackgroundImage = images[i];

        }

        private void Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b==button2)
                color = new SolidBrush(Color.Violet);
            else if (b == button3)
                color = new SolidBrush(Color.Yellow);
            else if (b == button4)
                color = new SolidBrush(Color.Red);
            else if (b == button5)
                color = new SolidBrush(Color.Sienna);
            else if (b == button9)
                color = new SolidBrush(Color.DodgerBlue);
            else if (b == button10)
                color = new SolidBrush(Color.LightGreen);
            else if (b == button12)
                color = new SolidBrush(Color.Black);
            else if (b == button13)
                color = new SolidBrush(Color.Indigo);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد تريد الخروج!؟", "انتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            if (i == images.Length-1)
            {
                i = 0;
            }
            else
            {
                i++;
            }

            panel1.BackgroundImage = images[i];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            if (i == 0)
            {
                i = images.Length - 1;
            }
            else
            {
                i--;
            }

            panel1.BackgroundImage = images[i];
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == i)
            {
                panel3.BackgroundImage = WindowsFormsApplication1.Properties.Resources.correct;
                panel3.Visible = true;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.correct1);
                sound.PlaySync();

            }
            else
            {
                panel3.BackgroundImage = WindowsFormsApplication1.Properties.Resources.tryagain;
                panel3.Visible = true;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.tryagain1);
                sound.PlaySync();
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
