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
    public partial class abonement : Form
    {
        bool exp;
        bool old;
        private SqlConnection sqlCon = null;
        public abonement()
        {
            
            InitializeComponent();

            listView1.Size = new Size(1474, 704);
            sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            sqlCon.Open();
            SqlDataReader dataReade = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT colled,price,trener from [abonement]", sqlCon);
                dataReade = sqlCommand.ExecuteReader();
                ListViewItem item = null;
                while (dataReade.Read())
                {
                    

                    item = new ListViewItem(new string[] { Convert.ToString(dataReade["colled"]), Convert.ToString(dataReade["price"]),
                    Convert.ToString(dataReade["trener"])});
                    listView1.Items.Add(item);
                  
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
            //panel2.MouseEnter += async (s, a) =>
            // {
            //     panel2.Width = 300;
            //     while (!exp&& panel2.Location.X > panel1.Location.X + 3)
            //     {
            //         exp = true;
            //         await Task.Delay(1);
            //         panel2.Location = old ? new Point(panel2.Location.X - 3, panel2.Location.Y) :
            //         new Point(panel2.Location.X/10, panel2.Location.Y);
            //         exp = false;

            //     }
            // };

            //panel2.MouseEnter += async (s, a) =>
            //{

            //    while (!exp && panel1.Location.X != 50)
            //    {
            //        exp = true;
            //        await Task.Delay(1);
            //        panel2.Location = old ? new Point(panel2.Location.X + 3, panel2.Location.Y) :
            //        new Point(panel2.Location.X + (panel2.Width - panel2.Location.X) / 8 + 2, panel2.Location.Y);
            //        exp = false;

            //    }
            //};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            old = !old;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
            nado n = new nado();
            n.Close();
            abonement_main ab = new abonement_main();
            ab.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
