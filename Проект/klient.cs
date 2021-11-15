using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Проект
{
    public partial class klient : Form
    {
        public klient()
        {
            InitializeComponent();
            //panel3.Visible = false ;

            Size = new Size(1500, 800);
            
            pictureBox1.Size = new Size(1487, 837);
            label2.Location = new Point(1166, 223);
           // panel3.Location = new Point(1176, 260);
            label3.Location = new Point(1169, 381);
            label4.Location = new Point(1169, 550);
            panel2.Location = new Point (1353, 6);
            label4.Location = new Point(1169, 561);
            label1.Location = new Point(44, 3);





        }



        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //panel3.Visible = true;
            label2.ForeColor = Color.Silver;
            //panel3.BackColor = Color.Silver;

        }


        private void label2_MouseLeave(object sender, EventArgs e)
        {
          // panel3.Visible = false;
            label2.ForeColor = Color.White;
           // panel3.ForeColor = Color.White;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Silver;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Silver;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Close();
            Date_klient dk = new Date_klient();
            dk.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Close();
            add_klient ak = new add_klient();
            ak.Show();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Close();

            deleteKl ak = new deleteKl();
            ak.Show();

        }
    }
    
}
