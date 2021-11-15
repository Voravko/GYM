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
    public partial class delete : Form
    {
        private SqlConnection sqlCon = null;
        bool c1 = false;
        public delete()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener] ", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
               
                while (dataReader.Read())
                {
                    //item = new ListViewItem(new string[] { Convert.ToString(dataReader["name"]) });

                    //label4.Text = dataReader["name"].ToString();
                    //string id = dataReader["name"].ToString();
                    //comboBox1.Items.Add(item);
                    comboBox1.Items.Add(dataReader["name"]);

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (c1)
            {
                label5.Visible = false;
                label1.Visible = true;

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(
                              $"DELETE from Trener WHERE name = @name", sqlCon);
                command.Parameters.AddWithValue("name", comboBox1.Text);

                command.ExecuteNonQuery();

                timer1.Enabled = true;
                addTrenercs a = new addTrenercs();
                a.c--;

            }
            else
                label5.Visible = true;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // pictureBox4.Visible = true;
            pictureBox3.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            Trener tr = new Trener();
            tr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            comboBox1.SelectedIndex = -1;
            label1.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c1 = true;
                // MessageBox.Show("abonement");


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (c1)
            {
                label5.Visible = false;

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(
                              $"DELETE from Trener WHERE name = @name", sqlCon);
                command.Parameters.AddWithValue("name", comboBox1.Text);

                command.ExecuteNonQuery();

                timer1.Enabled = true;
                addTrenercs a = new addTrenercs();
                a.c--;
            }
            else
                label5.Visible = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }
    }
}
