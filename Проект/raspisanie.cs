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
    public partial class raspisanie : Form
    {

        string one;
        string t;
        string th;
        string f;
        private SqlConnection sqlCon = null;
        public raspisanie()
        {
            mainmenu m = new mainmenu();
            m.Close();
            InitializeComponent();
            //Size = new Size(1500, 800);
            //Location = new Point(0, 0);
            //pictureBox1.Size = new Size(1500, 805);
            //pictureBox1.Location = new Point(0, 0);
            //label1.Location = new Point(51, 181);


            //label5.Location = new Point(532, 181);
            //listView2.Location = new Point(532, 313);
            //listView3.Location = new Point(532, 459);







        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener] WHERE k = 1", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
               
                while (dataReader.Read())
                {


                    label4.Text = dataReader["name"].ToString();
                    string id = dataReader["name"].ToString();


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

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener] WHERE k = 2", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {


                    label10.Text = dataReader["name"].ToString();
                    string id = dataReader["name"].ToString();


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

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener] WHERE k = 3", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {


                    label13.Text = dataReader["name"].ToString();
                    string id = dataReader["name"].ToString();


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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener] WHERE k = 4", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {


                    label16.Text = dataReader["name"].ToString();
                    string id = dataReader["name"].ToString();


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
           


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time1 from [Trener] WHERE k = 1", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
                
                while (dataReader.Read())
                {
                    label6.Text = dataReader["time1"].ToString();
                    string id = dataReader["time1"].ToString();
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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time1 from [Trener] WHERE k = 2", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label12.Text = dataReader["time1"].ToString();
                    string id = dataReader["time1"].ToString();
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



            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time1 from [Trener] WHERE k = 3", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label11.Text = dataReader["time1"].ToString();
                    string id = dataReader["time1"].ToString();
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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time1 from [Trener] WHERE k = 4", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label17.Text = dataReader["time1"].ToString();
                    string id = dataReader["time1"].ToString();
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



            

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time2 from [Trener] WHERE k = 1", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label7.Text = dataReader["time2"].ToString();
                    string id = dataReader["time2"].ToString();

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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time2 from [Trener] WHERE k = 2", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label11.Text = dataReader["time2"].ToString();
                    string id = dataReader["time2"].ToString();

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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time2 from [Trener] WHERE k = 3", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label15.Text = dataReader["time2"].ToString();
                    string id = dataReader["time2"].ToString();

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


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT time2 from [Trener] WHERE k = 4", sqlCon);
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    label18.Text = dataReader["time2"].ToString();
                    string id = dataReader["time2"].ToString();

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

            SqlDataReader dataRea = null;
            
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT day1,day2,day3,k from [Trener] WHERE k = 1", sqlCon);
                dataRea = sqlCommand.ExecuteReader();

                comboBox1.Items.Clear();

                while (dataRea.Read())
                {

                    // item = new ListViewItem(new string[] { Convert.ToString(dataReade["day1"]), Convert.ToString(dataReade["day2"]), Convert.ToString(dataReade["day3"]) });
                    comboBox1.Items.Add(dataRea["day1"]);
                    comboBox1.Items.Add(dataRea["day2"]);
                    comboBox1.Items.Add(dataRea["day3"]);
                    one = dataRea["k"].ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataRea != null && !dataRea.IsClosed)
                {
                    dataRea.Close();
                }
            }


            SqlDataReader dataRead = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT day1,day2,day3,k from [Trener] WHERE k = 2", sqlCon);
                dataRead = sqlCommand.ExecuteReader();
               
                while (dataRead.Read())
                {

                    // item = new ListViewItem(new string[] { Convert.ToString(dataReade["day1"]), Convert.ToString(dataReade["day2"]), Convert.ToString(dataReade["day3"]) });
                    comboBox2.Items.Add(dataRead["day1"]);
                    comboBox2.Items.Add(dataRead["day2"]);
                    comboBox2.Items.Add(dataRead["day3"]);
                    t = dataRead["k"].ToString();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataRead != null && !dataRead.IsClosed)
                {
                    dataRead.Close();
                }
            }

            SqlDataReader dataRe = null;


            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT day1,day2,day3,k from [Trener] WHERE k = 3", sqlCon);
                dataRe = sqlCommand.ExecuteReader();

                while (dataRe.Read())
                {

                    // item = new ListViewItem(new string[] { Convert.ToString(dataReade["day1"]), Convert.ToString(dataReade["day2"]), Convert.ToString(dataReade["day3"]) });
                    comboBox3.Items.Add(dataRe["day1"]);
                    comboBox3.Items.Add(dataRe["day2"]);
                    comboBox3.Items.Add(dataRe["day3"]);
                    th = dataRe["k"].ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataRe != null && !dataRe.IsClosed)
                {
                    dataRe.Close();
                }
            }

            SqlDataReader dataReader1 = null;



            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT day1,day2,day3,k from [Trener] WHERE k = 4", sqlCon);
                dataReader1 = sqlCommand.ExecuteReader();

                while (dataReader1.Read())
                {

                    // item = new ListViewItem(new string[] { Convert.ToString(dataReade["day1"]), Convert.ToString(dataReade["day2"]), Convert.ToString(dataReade["day3"]) });
                    comboBox4.Items.Add(dataReader1["day1"]);
                    comboBox4.Items.Add(dataReader1["day2"]);
                    comboBox4.Items.Add(dataReader1["day3"]);
                    t = dataReader1["k"].ToString();



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader1 != null && !dataReader1.IsClosed)
                {
                    dataReader1.Close();
                }
            }

            if (Convert.ToInt32(one)==1)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (Convert.ToString(comboBox1.Items[i]) == "Суббота")
                    {
                        checkBox6.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Понедельник")
                    {
                        checkBox1.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Вторник")
                    {
                        checkBox2.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Среда")
                    {
                        checkBox3.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Четверг")
                    {
                        checkBox4.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Пятница")
                    {
                        checkBox5.Checked = true;

                    }
                    if (Convert.ToString(comboBox1.Items[i]) == "Воскресенье")
                    {
                        checkBox7.Checked = true;

                    }

                }
            }

            if (Convert.ToInt32(t)==2)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Convert.ToString(comboBox2.Items[i]) == "Суббота")
                    {
                        checkBox13.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Понедельник")
                    {
                        checkBox8.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Вторник")
                    {
                        checkBox9.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Среда")
                    {
                        checkBox10.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Четверг")
                    {
                        checkBox11.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Пятница")
                    {
                        checkBox12.Checked = true;

                    }
                    if (Convert.ToString(comboBox2.Items[i]) == "Воскресенье")
                    {
                        checkBox14.Checked = true;

                    }
                }
            }

            if (Convert.ToInt32(th)==3)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (Convert.ToString(comboBox3.Items[i]) == "Суббота")
                    {
                        checkBox20.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Понедельник")
                    {
                        checkBox15.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Вторник")
                    {
                        checkBox16.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Среда")
                    {
                        checkBox17.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Четверг")
                    {
                        checkBox18.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Пятница")
                    {
                        checkBox19.Checked = true;

                    }
                    if (Convert.ToString(comboBox3.Items[i]) == "Воскресенье")
                    {
                        checkBox21.Checked = true;

                    }
                }
            }
            if (Convert.ToInt32(f)==4)
            {


                for (int i = 0; i < 3; i++)
                {
                    if (Convert.ToString(comboBox4.Items[i]) == "Суббота")
                    {
                        checkBox27.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Понедельник")
                    {
                        checkBox22.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Вторник")
                    {
                        checkBox23.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Среда")
                    {
                        checkBox24.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Четверг")
                    {
                        checkBox25.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Пятница")
                    {
                        checkBox26.Checked = true;

                    }
                    if (Convert.ToString(comboBox4.Items[i]) == "Воскресенье")
                    {
                        checkBox28.Checked = true;

                    }
                }
            }


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            Trener tr = new Trener();
            tr.Show();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void raspisanie_Load(object sender, EventArgs e)
        {

        }
    }
}



    

