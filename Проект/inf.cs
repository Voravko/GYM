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
using MySql.Data.MySqlClient;

namespace Проект
{
    public partial class inf : Form
    {
        private SqlConnection sqlCon = null;

        public inf()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                Date_klient d = new Date_klient();
                label8.Text = d.search;
                SqlCommand sqlCommand = new SqlCommand($"SELECT name,age,abonement,price from [klient] WHERE name LIKE{label8.Text}", sqlCon);
              

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {


                    label6.Text = dataReader["name"].ToString();
                    string id = dataReader["name"].ToString();

                    label7.Text = dataReader["age"].ToString();
                    string idi = dataReader["age"].ToString();

                    comboBox1.Items.Add(dataReader["abonement"]);

                    label9.Text = dataReader["price"].ToString();
                    string i = dataReader["price"].ToString();


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

        private void inf_Load(object sender, EventArgs e)
        {

        }
    }
}
