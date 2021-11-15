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
using System.Net;
using System.Net.Mail;
using S22.Imap;


namespace Проект
{
    public partial class reg : Form
    {

        bool o = false;
        bool t = false;
        bool th = false;
        double kod;
        bool gl = true;
        bool asa = false;
        Random rand = new Random();


        private SqlConnection sqlCon = null;

        public reg()
        {

            Form1 h = new Form1();
            h.Close();
            InitializeComponent();
            label4.Visible = false;

            Size = new Size(1510, 850);
            pictureBox1.Size = new Size(1515, 850); //1348; 509 683; 472
            label2.Location = new Point(683, 472);//697; 666 1004; 514  571; 260 571; 386 341; 34
            label1.Location = new Point(697, 666);
            pictureBox2.Location = new Point(1004, 514);
            pictureBox3.Location = new Point(1004, 514);

            maskedTextBox1.Location = new Point(484, 270);
            maskedTextBox1.Size = new Size(566, 34);

            textBox2.Location = new Point(484, 392);
            textBox2.Size = new Size(568, 34);
            maskedTextBox2.Location = new Point(486, 530);
            maskedTextBox2.Size = new Size(514, 34);


            pictureBox4.Location = new Point(461, 177);
            pictureBox4.Size = new Size(612, 486);
            pictureBox5.Location = new Point(461, 177);
            pictureBox5.Size = new Size(612, 486);
            pictureBox6.Location = new Point(1427, 771);
            pictureBox6.Size = new Size(612, 486);

            label5.Location = new Point(216, 205);
            label5.Size = new Size(162, 34);
            panel1.Location = new Point(479, 269);
            panel1.Size = new Size(587, 307);

            label4.Location = new Point(136, 121);
            //label4.Size = new Size(296, 37); 151; 148
            maskedTextBox3.Location = new Point(139, 141);
            maskedTextBox3.Size = new Size(289, 41);

            label11.Location = new Point(151, 148);

            label8.Location = new Point(481, 253);
            label9.Location = new Point(481, 376);
            label10.Location = new Point(481, 510);

            label3.Location = new Point(480, 270);
            label6.Location = new Point(480, 393);
            label7.Location = new Point(480, 527);
            label12.Location = new Point(600, 620);
            label13.Location = new Point(686, 363);
            // label12.Location = new Point(552, 597);
            label15.Location = new Point(672, 634);
            label14.Location = new Point(735, 725);







        }
        private void reg_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Visible = false;
            maskedTextBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            maskedTextBox2.UseSystemPasswordChar = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            label4.Visible = false;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
                label2.Visible = false;


            }




        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {



            label3.Visible = false;
            label8.Visible = true;
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            label7.Visible = false;
            label10.Visible = true;
        }
        bool gf = false;
        private void label1_Click(object sender, EventArgs e)
        {

            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {





                    if (textBox2.Text != String.Empty)
                    {
                        t = true;
                    }
                    if (maskedTextBox1.Text != String.Empty)
                    {
                        o = true;

                    }
                    if (maskedTextBox2.Text != String.Empty)
                    {
                        th = true;
                    }
                    if (o == true && t == true && th == true)
                    {
                        label15.Visible = false;
                        SqlDataReader dataRea = null;
                        try
                        {
                            SqlCommand sqlCommand = new SqlCommand("SELECT login from [bla]", sqlCon);
                            dataRea = sqlCommand.ExecuteReader();

                            while (dataRea.Read())
                            {
                                comboBox1.Items.Add(dataRea["login"]);
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
                        if (comboBox1.Items[0] == null)
                        {
                            gf = true;
                        }
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {

                            if (Convert.ToString(comboBox1.Items[i]) != maskedTextBox1.Text)
                            {
                                label12.Visible = false;
                                gf = true;
                            }
                            if (Convert.ToString(comboBox1.Items[i]) == maskedTextBox1.Text)
                            {
                                label12.Visible = true;

                            }







                            kod = rand.Next(100, 999);
                            if (gf)
                            {
                                if ((textBox2.Text.Contains("@")))
                                {
                                    if ((textBox2.Text.Contains("gmail.com")) || (textBox2.Text.Contains("mail.ru")))
                                    {
                                        label12.Visible = false;
                                        label13.Visible = false;


                                        // отправитель - устанавливаем адрес и отображаемое в письме имя
                                        MailAddress from = new MailAddress("voravkoliza8@gmail.com", "Спорт-клуб 'Олимпик'");
                                        // кому отправляем
                                        MailAddress to = new MailAddress(textBox2.Text);
                                        // создаем объект сообщения
                                        MailMessage m = new MailMessage(from, to);

                                        // тема письма
                                        m.Subject = "Код безопасности";
                                        // текст письма
                                        m.Body = "Здравствуйте, " + maskedTextBox1.Text + Environment.NewLine + "Введите код: " + kod + " в появившеяся поле!" + Environment.NewLine + "Хорошего вам дня!";
                                        // письмо представляет код html
                                        m.IsBodyHtml = true;
                                        // адрес smtp-сервера и порт, с которого будем отправлять письмо
                                        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                                        // логин и пароль
                                        smtp.Credentials = new NetworkCredential("voravkoliza8@gmail.com", "liza0606");
                                        smtp.EnableSsl = true;
                                        smtp.Send(m);
                                        panel1.Visible = true;
                                        // label4.Visible = true;
                                        label5.Visible = true;
                                        label8.Visible = false;
                                        label9.Visible = false;
                                        label10.Visible = false;
                                        label12.Visible = false;
                                        label13.Visible = false;
                                        label15.Visible = false;

                                        maskedTextBox1.Visible = false;
                                        maskedTextBox3.Visible = true;
                                        maskedTextBox2.Visible = false;
                                        label12.Visible = false;
                                        label1.Visible = false;

                                    }
                                    else
                                        label13.Visible = true;


                                }
                                else
                                {
                                    label13.Visible = true;
                                }

                            }
                            else
                            {
                                label12.Visible = true;
                            }
                        }

                    }
                    else
                        label15.Visible = true;
                }
            }

            catch (WebException)
            {
                MessageBox.Show("Нет интернет подключения!");
            }
           

        }

    


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            reg r = new reg();
            r.Close();
            mainmenu g = new mainmenu();
            g.Show();
           

            timer1.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
      
        private void label5_Click(object sender, EventArgs e)
        {

            if (maskedTextBox3.Text != String.Empty)
            {
                asa = true;
            }

            if (asa == true)
            {
                double d = Convert.ToDouble(maskedTextBox3.Text);

                if (d == kod)
                {
                    panel1.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    
                    maskedTextBox3.Visible = false;
                    SqlCommand command = new SqlCommand(
                               $"INSERT INTO [bla] (login,pass,email) VALUES (@login, @pass,@email)", sqlCon);
                    command.Parameters.AddWithValue("login", maskedTextBox1.Text);
                    command.Parameters.AddWithValue("pass", maskedTextBox2.Text);
                    command.Parameters.AddWithValue("email", textBox2.Text);
                    command.ExecuteNonQuery();
                    pictureBox4.Visible = true;
                    timer1.Enabled = true;
                    label2.Visible = false;
                }
                else
                {
                    label5.ForeColor = Color.Red;
                }
            }
            else
                label5.ForeColor = Color.Red;






        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Gray;

        }

    

        private void textBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
            label9.Visible = true;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            label11.Visible = false;
            label4.Visible = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
           
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
            if (Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
              

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.White;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {

            label14.ForeColor = Color.Gray;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
           // maskedTextBox2.SelectionStart = maskedTextBox2.TextLength - 1;
            label3.Visible = false;
            label8.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label9.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label10.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
           
        }

        

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            label4.Visible = true;
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
           // maskedTextBox2.SelectionStart = maskedTextBox2.TextLength - 1;
            label3.Visible = false;
            label8.Visible = true;
        }
    }
}
