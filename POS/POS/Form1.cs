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

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BUBT Study\Shuvo\C#\POS\POS\POSdb.mdf; Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username='" + comboBox1.Text + "' and password='" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                main m = new main();
                this.Hide();
                m.Show();
                //Refresh();
            }
            else
            {
                label3.Show();
                textBox2.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pOSdbDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.pOSdbDataSet.Login);

        }
    }
}
