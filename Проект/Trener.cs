using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Trener : Form
    {
        bool exp;
      
        public Trener()
        {
   


            InitializeComponent();
            mainmenu m = new mainmenu();
            m.Close();
            timer1.Enabled = true;

            Size = new Size(1500, 800);
            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(190, 43);


            pictureBox2.Location = new Point(970, -9);
            pictureBox2.Size = new Size(533, 814);

            label2.Location = new Point(1128, 186);
            label2.Size = new Size(253, 40);


            label1.Location = new Point(45, 3);
           // label2.Size = new Size(253, 40);

            label3.Location = new Point(1132, 376);
            label3.Size = new Size(242, 40);

            label4.Location = new Point(1132, 554);
            label4.Size = new Size(195, 40); //1235; 800

            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(1235, 800);

            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Size = new Size(1235, 800);

            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Size = new Size(1235, 800);

            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Size = new Size(1235, 800);
            label5.Size = new Size(37, 41);
            label5.Location = new Point(1443, -2);


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            timer3.Enabled = false;
            timer4.Enabled = true;

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            timer4.Enabled = false;
            timer1.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
           
        }

      

        private void label2_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Close();
            this.Close();
            //nado n = new nado();
            //n.Show();
            raspisanie ras = new raspisanie();
            ras.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu n = new mainmenu();
            n.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Close();
            this.Close();
            //nado n = new nado();
            //n.Show();
            addTrenercs trener = new addTrenercs();
            trener.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Close();
            this.Close();
            //nado n = new nado();
            //n.Show();
            delete dele = new delete();
            dele.Show();
        }
    }
}
