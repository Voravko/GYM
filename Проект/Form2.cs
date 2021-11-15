using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;

namespace Проект
{

    public partial class Form2 : Form
    {

        int kodik;
        public Form2()
        {
            InitializeComponent();
            Random rand = new Random();
            kodik = rand.Next(1000, 9999);

        }

        private void регистрацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;




        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;


        }

     

        private void основноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            listBox1.Visible = false;
            listBox3.Visible = false;
            listBox5.Visible = false;
            listBox4.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;



        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox4.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;



        }

        private void тренерToolStripMenuItem_Click(object sender, EventArgs e)
        {

            listBox3.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
            listBox5.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;



        }

        private void абонементыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox5.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
            listBox3.Visible = false;
            listBox6.Visible = false;
            listBox7.Visible = false;

        }

        private void расчетДоходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox6.Visible = true;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
            listBox3.Visible = false;
            listBox5.Visible = false;
            listBox7.Visible = false;
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox7.Visible = true;
            listBox6.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
            listBox3.Visible = false;
            listBox5.Visible = false;
            panel1.Visible = false;
          

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
            //textBox1.Visible = true;

            listBox7.Visible = false;
            listBox6.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            listBox4.Visible = false;
            listBox3.Visible = false;
            listBox5.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            

            
          
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
