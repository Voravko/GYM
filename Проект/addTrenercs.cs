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


    public partial class addTrenercs : Form
    {
        bool o=false;
        bool t=false;
        bool ht = false;
        bool f=false;
        bool fa = false;
        bool c1 = false;
        bool c2 = false;
        bool c3 = false;


        public int c =1;

        
        private SqlConnection sqlCon = null;
        public addTrenercs()
        {
            mainmenu m = new mainmenu();
            m.Close();
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            if (o && t && ht&& f && fa)
            {
                label20.Visible = false;

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label14.Visible = true;
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

            if (textBox2.Text != String.Empty)
            {
                t = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != String.Empty)
            {
                ht = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label17.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label18.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label15.Visible = true;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label16.Visible = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label14.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Gray;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            Trener tr = new Trener();
            tr.Show();
        }
        string th;
        int j= 0;
        private void panel2_Click(object sender, EventArgs e)
        {
            j++;
           

                if (o && t && ht && f && fa&&c1&&c2&&c3)
                {

                    label20.Visible = false;
                    if (Convert.ToInt32(textBox4.Text) > Convert.ToInt32(textBox5.Text) || Convert.ToInt32(textBox4.Text) == Convert.ToInt32(textBox5.Text))
                    {
                        label19.Visible = true;

                    }
                    else
                    {
                        label19.Visible = false;

                        sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
                        sqlCon.Open();
                        SqlDataReader dataRe = null;




                        SqlCommand command = new SqlCommand(
                                           $"INSERT INTO [Trener] (name,sport,time1,time2,day1,day2,day3,k) VALUES (@name,@sport,@time1,@time2,@day1,@day2,@day3,@k)", sqlCon);
                        command.Parameters.AddWithValue("name", textBox1.Text);
                        command.Parameters.AddWithValue("sport", textBox3.Text);
                        command.Parameters.AddWithValue("time1", textBox4.Text);
                        command.Parameters.AddWithValue("time2", textBox5.Text);
                        command.Parameters.AddWithValue("day1", comboBox1.Text);
                        command.Parameters.AddWithValue("day2", comboBox2.Text);
                        command.Parameters.AddWithValue("day3", comboBox3.Text);
                        command.Parameters.AddWithValue("k", c);
                        c++;
                     
                    



                        command.ExecuteNonQuery();
                        pictureBox3.Visible = true;
                        timer1.Enabled = true;

                    }
                }
                else
                {
                    label20.Visible = true;
                }
            
            

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != String.Empty)
            {
                f = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != String.Empty)
            {
                fa = true;
            }
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.ForeColor = Color.Gray;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label21.ForeColor = Color.Gold;

        }

        private void label21_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c2 = true;
                // MessageBox.Show("abonement");


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c1 = true;
                // MessageBox.Show("abonement");


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                c3 = true;
                // MessageBox.Show("abonement");


            }
        }
    }
}
 