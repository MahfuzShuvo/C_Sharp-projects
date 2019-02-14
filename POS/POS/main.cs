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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            pdl = new List<ProductList>();
        }
        private List<ProductList> pdl;
        private float sum = 0;
        private float vat = 0;
        private float total = 0;
        private void Refresh()
        {
            dataGridView1.DataSource = pdl.ToList();

            vat = (sum * 5) / 100;
            total = vat + sum;
            textBox2.Text = sum.ToString();
            textBox3.Text = vat.ToString();
            textBox4.Text = total.ToString();

        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panel6.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panel7.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panel8.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel8.Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel9.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            panel10.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            panel12.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            panel13.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel13.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel14.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pay p = new Pay();
           // this.Hide();
            p.Show();
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.LightGray;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.White;
        }

        private void main_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pdl.Add(new ProductList { Name = label37.Text, Quantity = float.Parse(domainUpDown1.Text), Price= float.Parse(domainUpDown1.Text) * float.Parse(label38.Text) });
            sum += (float.Parse(domainUpDown1.Text) * float.Parse(label38.Text));
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pdl.Add(new ProductList { Name = label3.Text, Quantity = float.Parse(domainUpDown2.Text), Price = float.Parse(domainUpDown2.Text) * float.Parse(label41.Text) });
            sum += (float.Parse(domainUpDown2.Text) * float.Parse(label41.Text));
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pdl.Add(new ProductList { Name = label4.Text, Quantity = float.Parse(domainUpDown3.Text), Price = float.Parse(domainUpDown3.Text) * float.Parse(label42.Text) });
            sum += (float.Parse(domainUpDown3.Text) * float.Parse(label42.Text));
            Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pdl.Add(new ProductList { Name = label5.Text, Quantity = float.Parse(domainUpDown4.Text), Price = float.Parse(domainUpDown4.Text) * float.Parse(label44.Text) });
            sum += (float.Parse(domainUpDown4.Text) * float.Parse(label44.Text));
            Refresh();
        }
    }
}
