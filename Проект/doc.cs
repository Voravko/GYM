using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Проект
{
    public partial class doc : Form
    {
        private SqlConnection sqlCon = null;
        bool hg = true;
        public doc()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id from [klient]", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
                comboBox1.Items.Clear();


                while (dataReader.Read())
                {

                    comboBox2.Items.Add(dataReader["Id"]);



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
                SqlCommand sqlCommand = new SqlCommand("SELECT abonement from [klient]", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
                comboBox1.Items.Clear();


                while (dataReader.Read())
                {

                    comboBox3.Items.Add(dataReader["abonement"]);



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
                SqlCommand sqlCommand = new SqlCommand("SELECT price from [klient]", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
                comboBox1.Items.Clear();


                while (dataReader.Read())
                {

                    comboBox3.Items.Add(dataReader["price"]);



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
            int c = 0;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                c++;
            }
            label6.Text = Convert.ToString(c);









            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT price from [klient] WHERE  date >= @date1 AND date <= @date2", sqlCon);
                sqlCommand.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
                sqlCommand.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString("MM.dd.yyyy"));
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    comboBox1.Items.Add(dataReader["price"]);



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
            int f = 0;

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                f =+ Convert.ToInt32(comboBox1.Items[i]);

            }

            label5.Text = Convert.ToString(f);


            // путь к документу
            
        }
        
        private void label9_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(dateTimePicker1.Value.ToString());

           
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT Id from [klient] WHERE  date >= @date1 AND date <= @date2", sqlCon);
                sqlCommand.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
                sqlCommand.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString("MM.dd.yyyy"));

                comboBox2.Items.Clear();
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    comboBox2.Items.Add(dataReader["Id"]);
                




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
            int c = 0;
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                c++;
            }
            label6.Text = Convert.ToString(c);


            try
            {

                SqlCommand sqlCommand = new SqlCommand("SELECT price from [klient] WHERE  date >= @date1 AND date <= @date2", sqlCon);
                sqlCommand.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
                sqlCommand.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString("MM.dd.yyyy"));
                comboBox1.Items.Clear();

                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {

                    comboBox1.Items.Add(dataReader["price"]);



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
            int f = 0;

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                f += Convert.ToInt32(comboBox1.Items[i]);

            }

            label5.Text = Convert.ToString(f);

        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Gray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string one = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            string two = dateTimePicker2.Value.ToString("dd.MM.yyyy");
            if (one==two)
            {
                hg = false;
            }
            string pathDocument = AppDomain.CurrentDomain.BaseDirectory + "Отчёт.docx";
            

            DocX document = DocX.Create(pathDocument);
            if (hg)
            {
                document.InsertParagraph($"Отчёт по продажам c {one} по {two}").


                     Font("Calibri").

                     FontSize(24).

                     Bold().


                     Alignment = Alignment.center;
            }
            else
                document.InsertParagraph($"Отчёт по продажам на {one} ").


                     Font("Calibri").

                     FontSize(24).

                     Bold().


                     Alignment = Alignment.center;

            document.InsertParagraph("");
            SqlDataReader dataReade = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name, price, abonement from [klient]  WHERE  date >= @date1 AND date <= @date2", sqlCon);
                sqlCommand.Parameters.AddWithValue("date1", dateTimePicker1.Value.ToString("MM.dd.yyyy"));
                sqlCommand.Parameters.AddWithValue("date2", dateTimePicker2.Value.ToString("MM.dd.yyyy"));
                dataReade = sqlCommand.ExecuteReader();
                


                while (dataReade.Read())
                {

                    string n = dataReade["name"].ToString();
                    string p = dataReade["price"].ToString();
                    string a = dataReade["abonement"].ToString();

                    document.InsertParagraph($"{n} приобрел абонемент '{a}' на сумму {p}");




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
            document.InsertParagraph("");

            document.InsertParagraph($"Продано всего абонементов {label6.Text}");
            document.InsertParagraph($"Всего прибыли {label5.Text}");
            string s = label5.Text;
            double d = double.Parse(s);
            d = d * 0.85;
            document.InsertParagraph($"Прибыль с учетом налога {d}");


            document.Save();
            try
                {
                    // Запускаем нужный файл
                    System.Diagnostics.Process.Start("Отчёт.docx");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            
        }
    }
}
