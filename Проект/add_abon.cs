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


    public partial class add_abon : Form
    {
        bool o = false;
        bool t = false;
        bool th = false;
        private SqlConnection sqlCon = null;
        public add_abon()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT name from [Trener]", sqlCon);
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
            if (o && t && th)
                {
                    label20.Visible = false;
                }
            

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

        private void textBox1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label6.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label7.Visible = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }

        private void label1_DragLeave(object sender, EventArgs e)
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

        private void panel1_Click(object sender, EventArgs e)
        {
            string hg =Convert.ToString( textBox2.Text);
            if (o && t && th)
            {
                if (!(hg.Contains("0")))
                {

                    label22.Visible = false;
                    sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                    sqlCon.Open();
                    SqlCommand command = new SqlCommand(
                                   $"INSERT INTO [abonement] (colled,price,trener) VALUES (@colled,@price,@trener)", sqlCon);
                    command.Parameters.AddWithValue("colled", textBox1.Text);
                    command.Parameters.AddWithValue("price", textBox2.Text);
                    command.Parameters.AddWithValue("trener", textBox3.Text);
                    pictureBox3.Visible = true;


                    command.ExecuteNonQuery();
                }
                else
                    label22.Visible = true;
            }
            else
            {
                label20.Visible = true;
            }
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            abonement_main ab = new abonement_main();
            ab.Show();
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Gray;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                t = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            pictureBox3.Visible = false;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                th = true;
                // MessageBox.Show("abonement");


            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
