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
    public partial class delete_Ab : Form
    {
        private SqlConnection sqlCon = null;
        bool c1 = false;
        public delete_Ab()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT colled from [abonement] ", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    //item = new ListViewItem(new string[] { Convert.ToString(dataReader["name"]) });

                    //label4.Text = dataReader["name"].ToString();
                    //string id = dataReader["name"].ToString();
                    //comboBox1.Items.Add(item);
                    comboBox1.Items.Add(dataReader["colled"]);

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

        private void textBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (c1)
            {
                label3.Visible = false;
                label5.Visible = true;

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand(
                              $"DELETE from abonement WHERE colled = @colled", sqlCon);
                command.Parameters.AddWithValue("colled", comboBox1.Text);

                command.ExecuteNonQuery();
                pictureBox4.Visible = true;

            }
            else
                label3.Visible = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
           
            abonement_main a = new abonement_main();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c1 = true;
                // MessageBox.Show("abonement");


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            comboBox1.SelectedIndex = -1;
            label5.Visible = false;

        }
    }
}
