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

    public partial class Form1 : Form
    {
        bool chooise;
        bool h;
        private SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
            Size = new Size(1510, 850);
            pictureBox1.Size = new Size(1515, 850); //1348; 509

            pictureBox2.Location = new Point(1348, 509);
            pictureBox3.Location = new Point(1348, 509);

            maskedTextBox1.Location = new Point(900, 413);
            maskedTextBox1.Size = new Size(490, 34);

            maskedTextBox2.Location = new Point(900, 518); //1063; 606
            label1.Location = new Point(1050, 609); //178; 58 1047; 597 1103; 471 1082; 678 269; 64
            label2.Location = new Point(1103, 471);
            panel1.Location = new Point(1012, 668);
            label3.Location = new Point(65, 7);
           panel1.Size = new Size(269, 64); //1348; 509
         
            label4.Location = new Point(1447, 9);
            pictureBox5.Location = new Point(1428, 771);//79; 81
            pictureBox5.Size = new Size(79,81);//79; 81

            label5.Location = new Point(900,412);
            label6.Location = new Point(900, 518);
            label7.Location = new Point(901, 393);
            label8.Location = new Point(901, 498);










            //  label1.Size = new Size(178, 80); 1036; 672


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            if(sqlCon.State==ConnectionState.Open)
            {
               // MessageBox.Show(")");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand(
            //    $"INSERT INTO [bla] (login,pass) VALUES (@login, @pass)", sqlCon);
            //command.Parameters.AddWithValue("login", textBox1.Text);
            //command.Parameters.AddWithValue("pass", textBox2.Text);


            //MessageBox.Show(command.ExecuteNonQuery().ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string f = textBox3.Text;
            //string g = textBox4.Text;
          
            //SqlDataReader rea = null;
            //try
            //{
            //    SqlCommand com = new SqlCommand($"SELECT * FROM bla WHERE pass = {(textBox4.Text).ToString()} ", sqlCon);
      
            //    rea = com.ExecuteReader();
            //    while (rea.Read())
            //    {
            //        if (rea != null)
            //        {
            //            MessageBox.Show(":)");
            //        }
            //        else
            //            MessageBox.Show(":(");
                    
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (rea != null && !rea.IsClosed)
            //    {
            //        rea.Close();
            //    }
            //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //abonement abon = new abonement();
            //abon.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //abonement abon = new abonement();
            //abon.Show();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            klient abon = new klient();
            abon.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            abonement_main b = new abonement_main();
            b.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            abonement g = new abonement();
            g.Show();

        }
        int click = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
            maskedTextBox2.UseSystemPasswordChar = false;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            maskedTextBox2.UseSystemPasswordChar = true;

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Visible = false;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                label2.Visible = false;
                chooise = true;

            }


            if (!Char.IsDigit(number))
            {
                e.Handled = false;
                label2.Visible = true;
            }
            if (number == ' ')
            {
                chooise = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           


            SqlDataReader rea = null;
            

            try
            {
                SqlCommand com = new SqlCommand("SELECT * FROM bla WHERE pass = @pass AND login =@login", sqlCon);
                com.Parameters.AddWithValue("pass", maskedTextBox2.Text);
                com.Parameters.AddWithValue("login", maskedTextBox1.Text);
                rea = com.ExecuteReader();



                while (rea.Read())
                {

                    
                    if (rea!=null)
                    {
                        // MessageBox.Show(":)");
                        h = true;

                    }
                   




                }

            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if (rea != null && !rea.IsClosed)
                {
                    rea.Close();
                }
            }
            if (h)
            {
                this.Close();
                mainmenu g = new mainmenu();
                g.Show();
            }


            try
            {
                    SqlCommand com = new SqlCommand("SELECT * FROM bla WHERE pass = @pass AND login =@login", sqlCon);
                    com.Parameters.AddWithValue("pass", maskedTextBox2.Text);
                    com.Parameters.AddWithValue("login", maskedTextBox1.Text);
                rea = com.ExecuteReader();



                while (rea.Read())
                    {
                   
                        label10.Text = rea["pass"].ToString();
                             string id = rea["pass"].ToString();
                             label11.Text = rea["login"].ToString();
                            string d = rea["login"].ToString();
                    if (maskedTextBox1.Text==label10.Text && maskedTextBox2.Text==label11.Text)
                        {
                        // MessageBox.Show(":)");
                        h = true;
                                
                        }
                   




                }

            }
                catch (Exception ex)
                {
                
                }
                finally
                {
                    if (rea != null && !rea.IsClosed)
                    {
                        rea.Close();
                    }
                }
            if(h)
            {
                this.Close();
                mainmenu g = new mainmenu();
                g.Show();
            }
            
            
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SandyBrown;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Close();
            reg r = new reg();
            r.Show();
           
        }

     

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Gray;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Visible = true;
            label6.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {

            label7.Visible = true;
            label5.Visible = false;
            maskedTextBox1.Enabled = true;

        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label6.Visible = false;
            maskedTextBox2.Enabled = true;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label5.Visible = false;
           // maskedTextBox1.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label6.Visible = false;
            //maskedTextBox2.Enabled = true;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void maskedTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;

        }
    }
    
}
