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
using Npgsql;


namespace Elite
{//CHARTS FORM: should have a pie chart showing from a total income how much was spent, showing a line chart of savings+spendings progress, showing the balance of savings

 //TARGETS FORM: should have again the balance of savings and to show a progress bar for each financial target.
 //EX: Target- a house which costs 350.000£ and the deposit needed is 70.000£. Then the progress bar should pe partially filled and a percentage of progress should come up.

 //JOURNAL FORM: should give the possibility to it's users to save txt files into the same database. The txt files will be automatically created through a programmable function.
 //The journal should have information such as: financial lessons and advices, daily thoughts or anything else that we can find usefull if we read it somewhere in future.

   
    public partial class Form1 : Form
    {
        public bool logged = false;
        public string user { get; set; }
        public Form1()
        {
            InitializeComponent();
        
           
            
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E39HUGAJ;Initial Catalog=EliteDB;Integrated Security=True");
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Nav.Height = button1.Height;
            Nav.Top = button1.Top;
            Nav.Left = button1.Left;
            Savings svng = new Savings();
            svng.UserName = user;
            openChildForm(svng);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nav.Height = button2.Height;
            Nav.Top = button2.Top;
            Nav.Left = button2.Left;
            Spendings spnd = new Spendings();
            spnd.UserName=user;
            openChildForm(spnd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nav.Height = button3.Height;
            Nav.Top = button3.Top;
            Nav.Left = button3.Left;
            Charts chrts = new Charts();
            chrts.UserName = user;
            openChildForm(chrts);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nav.Height = button4.Height;
            Nav.Top = button4.Top;
            Nav.Left = button4.Left;
            Targets trgts=new Targets();
            trgts.UserName = user;
            openChildForm(trgts);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nav.Height = button5.Height;
            Nav.Top = button5.Top;
            Nav.Left = button5.Left;
            Journal jrnl=new Journal();
            jrnl.UserName = user;
            openChildForm(jrnl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Form activeForm=null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm=childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Intro());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;
            string query= "SELECT * FROM accounts WHERE username='" + inputUsername.Trim() + "'AND password='" + inputPassword.Trim() + "'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

           
            if (dt.Rows.Count==1)
            {
                logged = true;
                user = textBox1.Text;
                if (logged == true)
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    panel2.Hide();
                }
            }
            else
            {
                
                label3.Text = "Account does not exist. Try again.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string inputUsername = textBox1.Text;
            string inputPassword = textBox2.Text;
            string query = "SELECT username FROM accounts WHERE username='" + inputUsername.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count<1)
            {
                conn.Open();
                string query1 = "INSERT INTO accounts(username,password) Values('" + inputUsername.Trim() + "','" + inputPassword.Trim() + "')";
                SqlCommand cmd = new SqlCommand(query1,conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                label3.ForeColor = Color.LimeGreen;
                label3.Text = "Account created! You can login now!";
            }
            else
            {
                label3.Text = "User already exists. Try again!";
            }
        }
    } 
    
}
