using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Проект
{
    public partial class Date_klient : Form
    {
        public string search;
        string name;
        private SqlConnection sqlCon = null;
        int age;
        public Date_klient()
        {
            InitializeComponent();



            listView1.Size = new Size(1474, 704);
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReade = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name,age,abonement,kolvo,price,phone from [klient]", sqlCon);
                dataReade = sqlCommand.ExecuteReader();
                ListViewItem item = null;
                while (dataReade.Read())
                {
                    comboBox2.Items.Clear();

                    item = new ListViewItem(new string[] { Convert.ToString(dataReade["name"]), Convert.ToString(dataReade["age"]),
                    Convert.ToString(dataReade["abonement"]),Convert.ToString(dataReade["kolvo"]),Convert.ToString(dataReade["price"]),Convert.ToString(dataReade["phone"])});
                    listView1.Items.Add(item);
                    comboBox1.Items.Add(dataReade["name"]);
                    comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
                    comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboBox2.Items.Add(dataReade["abonement"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReade != null && !dataReade.IsClosed)
                {
                    dataReade.Close();
                }
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searh_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            klient k = new klient();
            k.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;


            }
        }
        bool g=true;
        private void button1_Click_1(object sender, EventArgs e)
        {






            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            if (g)
            {
                panel2.Visible = true;
                panel3.Visible = true;
                comboBox2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                label9.Visible = true;

                label11.Visible = true;
                if(age <18)
                {
                    panel2.Height += 90;
                    label12.Visible = true;
                    label13.Visible = true;

                }

            }

            SqlDataReader dataReade = null;

            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                g = false;
                MessageBox.Show("Введите имя");
            }
            else
            {
                name = comboBox1.Text;
                try
                {
                    SqlCommand sqlCommand = new SqlCommand($"SELECT name,age,abonement,price,kolvo from [klient] WHERE name= @name", sqlCon);
                    sqlCommand.Parameters.AddWithValue("name", name);
                    
                    dataReade = sqlCommand.ExecuteReader();
                    ListViewItem item = null;
                    while (dataReade.Read())
                    {
                        item = new ListViewItem(new string[] { Convert.ToString(dataReade["name"]), Convert.ToString(dataReade["age"]),
                    Convert.ToString(dataReade["abonement"]),Convert.ToString(dataReade["kolvo"])});

                        label3.Text = dataReade["name"].ToString();
                        string id = dataReade["name"].ToString();
                        label8.Text = dataReade["age"].ToString();
                        string i = dataReade["age"].ToString();
                        age = Convert.ToInt32(dataReade["age"]);
                        label10.Text = dataReade["kolvo"].ToString();
                        string i3d = dataReade["kolvo"].ToString();
                        label11.Text = dataReade["price"].ToString();
                        string id5 = dataReade["price"].ToString();
                        label13.Text = dataReade["age"].ToString();
                        string id6 = dataReade["age"].ToString();





                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (dataReade != null && !dataReade.IsClosed)
                    {
                        dataReade.Close();
                    }
                }


            }

        }

        private void listView1_Click(object sender, EventArgs e)
        {
         
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
                panel2.Visible = false;
                panel3.Visible = false;
                comboBox2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label9.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
                panel2.Height -= 110;
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
