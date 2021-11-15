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
    public partial class add_klient : Form
    {
        bool o = false;
        bool t = false;
        bool ht = false;
        bool fa = false;
        bool f = false;


        private SqlConnection sqlCon = null;
        public add_klient()
        {
            InitializeComponent();
            


                if (o && t && ht && fa && f)
            {
                label20.Visible = false;

            }
            if (o && t  && fa && f)
            {
                label20.Visible = false;

            }
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;
            
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT colled from [abonement] ", sqlCon);
                dataReader = sqlCommand.ExecuteReader();
                ListViewItem item = null;
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

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    //this.pictureBox2.Size = image.Size;
                    pictureBox2.Image = image;
                    pictureBox2.Invalidate();
                    pictureBox2.Visible = true;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                f = true;
               // MessageBox.Show("abonement");


            }

        }          
                

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                o = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label7.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
           // label5.Visible = false;
            label6.Visible = true;
        }
        int age;
        private void label14_Click(object sender, EventArgs e)
        {
           


            if (o && t && ht && f && fa)
            {
                age = Convert.ToInt32(maskedTextBox1.Text);
                
                    label20.Visible = false;
                    SqlDataReader rea = null;

                    try
                    {
                        SqlCommand com = new SqlCommand($"SELECT price FROM abonement WHERE colled = @colled ", sqlCon);
                        com.Parameters.AddWithValue("colled", comboBox1.Text);


                        rea = com.ExecuteReader();
                        while (rea.Read())
                        {
                            label12.Text = rea["price"].ToString();
                            string id = rea["price"].ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show("lggkgkf");
                    }
                    finally
                    {
                        if (rea != null && !rea.IsClosed)
                        {

                            rea.Close();
                        }
                    }
                    int result = Convert.ToInt32(label12.Text) * Convert.ToInt32(comboBox2.Text);
                    label12.Text = Convert.ToString(result);
                DateTime dateTime = DateTime.Now;
                 

                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                    sqlCon.Open();
                    SqlCommand command = new SqlCommand(
                                   $"INSERT INTO [klient] (name,age,abonement,kolvo,price,phone,date) VALUES (@name,@age,@abonement,@kolvo,@price,@phone,@date)", sqlCon);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("age", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("abonement", comboBox1.Text);
                    command.Parameters.AddWithValue("kolvo", comboBox2.Text);
                    command.Parameters.AddWithValue("price", label12.Text);
                    command.Parameters.AddWithValue("phone", maskedTextBox2.Text);
                    command.Parameters.AddWithValue("date", dateTime.ToString("MM.dd.yyyy"));





                pictureBox3.Visible = true;


                    command.ExecuteNonQuery();


                
            }
            else
            {
                label20.Visible = true;
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            klient am = new klient();
            am.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label8.Visible = true;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            if (maskedTextBox2.Text != String.Empty)
            {
                ht = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(Convert.ToInt32(maskedTextBox1.Text)<18)
            {
                maskedTextBox2.Visible = true;
                label16.Visible = false;
                label13.Visible = true;
            }
            else
            {
                maskedTextBox2.Visible = true;

                label16.Visible = true;
                label13.Visible = false;


            }
            if (maskedTextBox1.Text != String.Empty)
            {
                t = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Gray;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            label12.Text = null;
            pictureBox3.Visible = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(comboBox2.Text))
            {
                fa = true;
                //MessageBox.Show("abonement");


            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Gray;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.White;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    //this.pictureBox2.Size = image.Size;
                    pictureBox2.Image = image;
                    pictureBox2.Invalidate();
                    pictureBox2.Visible = true;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
