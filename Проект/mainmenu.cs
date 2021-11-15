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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
            Size = new Size(1500, 800);
            pictureBox1.Size = new Size(1500, 805);
            pictureBox2.Size= new Size(280,360);
            pictureBox2.Location = new Point(86, 198);
            pictureBox4.Size = new Size(285, 362);
            pictureBox4.Location = new Point(428, 191);
            pictureBox3.Size = new Size(361, 365);
            pictureBox3.Location = new Point(745, 198);
            pictureBox5.Size = new Size(285, 370);
            pictureBox5.Location = new Point(1174,188);
            pictureBox8.Size = new Size(79, 81);
            pictureBox8.Location = new Point(1401, 710);
            label4.Size = new Size(37, 41);
            label4.Location = new Point(1443, -2);




        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(280, 360);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(290, 370);

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(280, 362);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(290, 372);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(361, 366);

        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(371, 370);

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(285, 370);

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = new Size(295, 380);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Trener tr = new Trener();
            tr.Show();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            abonement_main am = new abonement_main();
            am.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            klient k = new klient();
            k.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();

            doc d = new doc();
            d.Show();
        }
    }
}
