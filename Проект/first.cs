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
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
            Size = new Size(1514, 859);
            //  pictureBox1.Location = new Point(193, -154);  395; -82  748, 631
            pictureBox1.Size = new Size(1514, 1000);
            pictureBox2.Size = new Size(1514, 1000);
            pictureBox3.Location = new Point(395, -82);
            pictureBox3.Size = new Size(757, 584);
            // label1.Size = new Size(574, 505);
            label1.Location = new Point(605, 485);
            label2.Location = new Point(748, 631);


            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;

            pictureBox3.Visible = true;
            pictureBox2.Visible = true;

            timer2.Enabled = true;
          
            timer1.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            

            Form1 f = new Form1();
            f.Show();
            timer2.Enabled = false;
            
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Show();
        }
    }
}
