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

namespace Elite
{
    public partial class Spendings : Form
    {
        public string UserName { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E39HUGAJ;Initial Catalog=EliteDB;Integrated Security=True");

        public Spendings()
        {
            InitializeComponent();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();

           
            
        }

        private void Spendings_Load(object sender, EventArgs e)
        {   



            // TODO: This line of code loads data into the 'eliteDBDataSet.DataForEveryUser' table. You can move, or remove it, as needed.
            this.dataForEveryUserTableAdapter.Fill(this.eliteDBDataSet.DataForEveryUser);
            string user = UserName;//ASA S-A TRANSFERAT USERNAME-UL DIN FORM1.
            label2.Text= user;
            string query = "SELECT Amount,Time FROM DataForEveryUser WHERE Account='" + label2.Text + "' AND TypeOfTransaction='-'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            
            
            string query1 = "SELECT sum(CAST(amount AS DECIMAL(10,2))) FROM DataForEveryUser WHERE Account='"+UserName+"' AND TypeOfTransaction='-'";
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, conn);
            DataTable dt1 = new DataTable();
            adapter1.Fill(dt1);
            label9.Text= dt1.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)//todays date
            {
                conn.Open();
                string query = "INSERT INTO DataForEveryUser(Account,TypeOfTransaction,Amount,Time) Values('" + UserName + "','-','" + numericUpDown1.Value + "','" + DateTime.Today.ToString("dd/MM/yyyy") + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (checkBox2.CheckState == CheckState.Checked)//specific date
            {
                conn.Open();
                string query = "INSERT INTO DataForEveryUser(Account,TypeOfTransaction,Amount,Time) Values('" + UserName + "','-','" + numericUpDown1.Value + "','" + dateTimePicker1.Text + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }//Aici se va folosi formula de insert into values etc cu username-ul transferat la form prin label4.text si valorile introduse
             //SqlCommand innerjoin "SELECT username FROM accounts INNER JOIN DataForEveryUser ON accounts.username=DataForEveryUser.Account" 
             //Cu aceasta comanda voi reusi sa arat istoricul activitatii din database al fiecarui user inregistrat cu succes
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = decimal.MaxValue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox2.CheckState = CheckState.Unchecked;
                dateTimePicker1.Hide();
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
                dateTimePicker1.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.CheckState = CheckState.Unchecked;
                dateTimePicker1.Show();
            }
            else if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox2.CheckState = CheckState.Unchecked;
                dateTimePicker1.Hide();
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                checkBox4.CheckState = CheckState.Unchecked;
                dateTimePicker2.Hide();
            }
            else if (checkBox4.CheckState == CheckState.Checked)
            {
                checkBox3.CheckState = CheckState.Unchecked;
                dateTimePicker2.Show();
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                checkBox3.CheckState = CheckState.Unchecked;
                dateTimePicker2.Show();
            }
            else if (checkBox3.CheckState == CheckState.Checked)
            {
                checkBox4.CheckState = CheckState.Unchecked;
                dateTimePicker2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)//todays date
            {
                conn.Open();
                string query = "DELETE FROM DataForEveryUser WHERE Account='" + UserName + "' AND TypeOfTransaction='-' AND Amount='" + numericUpDown2.Value + "' AND Time='" + DateTime.Today.ToString("dd/MM/yyyy") + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else if (checkBox4.CheckState == CheckState.Checked)//specific date
            {
                conn.Open();
                string query = "DELETE FROM DataForEveryUser WHERE Account='" + UserName + "' AND TypeOfTransaction='-' AND Amount='" + numericUpDown2.Value + "' AND Time='" + dateTimePicker2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
