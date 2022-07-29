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
    public partial class deleteKl : Form
    {
        bool c1 = false;
         
        private SqlConnection sqlCon = null;
        public deleteKl()
        {
            mainmenu m = new mainmenu();
            m.Close();
            InitializeComponent();

           

            
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [klient] ", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    //item = new ListViewItem(new string[] { Convert.ToString(dataReader["name"]) });

                    //label4.Text = dataReader["name"].ToString();
                    //string id = dataReader["name"].ToString();
                    //comboBox1.Items.Add(item);
                    comboBox1.Items.Add(dataReader["name"]);
                    comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
                    comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (c1)
            {
                label5.Visible = false;

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(
                              $"DELETE from klient WHERE name = @name", sqlCon);
                command.Parameters.AddWithValue("name", comboBox1.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString());
                pictureBox3.Visible = true;
                //label3.Visible = true;

            }
            else
                label5.Visible = true;




        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu m = new mainmenu();
            m.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            comboBox1.SelectedIndex = -1;
            //label3.Visible = false;

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
           // label3.ForeColor = Color.Gray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
           // label3.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (c1)
            {
                label5.Visible = false;

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(
                              $"DELETE from klient WHERE name = @name", sqlCon);
                command.Parameters.AddWithValue("name", comboBox1.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString());
                pictureBox3.Visible = true;
                //label3.Visible = true;
                timer1.Enabled = true;

            }
            else
                label5.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c1 = true;
                // MessageBox.Show("abonement");


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }
    }
}
