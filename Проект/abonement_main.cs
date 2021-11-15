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
    public partial class abonement_main : Form
    {
        public abonement_main()
        {
            

            InitializeComponent();
            Size = new Size(1510, 837);
            pictureBox1.Size = new Size(1510, 837);
            panel1.Size = new Size(43, 51);
            label1.Location = new Point(1223, 209); //1185; 275
            label2.Location = new Point(1223, 417); //1185; 275
            label3.Location = new Point(1223,657); //1185; 275
            label4.Location = new Point(1466, 9); //1185; 275
            panel1.Location = new Point(0, 0); //1185; 275

            label5.Location = new Point(52, 6); //1185; 275




        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
          
            add_abon h = new add_abon();
            h.Show();
           
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Silver;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Silver;

        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;

        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Silver;

        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            abonement ab = new abonement();
            ab.Show();

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
           
            delete_Ab d = new delete_Ab();
            d.Show();

        }

      

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
