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
using System.IO;

namespace Elite
{
    public partial class Journal : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E39HUGAJ;Initial Catalog=EliteDB;Integrated Security=True");
        public string UserName { get; set; }
        public Journal()
        {
            InitializeComponent();

        }

        private void Journal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eliteDBDataSet3.JournalLocations' table. You can move, or remove it, as needed.
            this.journalLocationsTableAdapter.Fill(this.eliteDBDataSet3.JournalLocations);


            string user = UserName;//ASA S-A TRANSFERAT USERNAME-UL DIN FORM1.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
        public string JournalsFolder;
        private void button1_Click(object sender, EventArgs e)
        {
           
            
                System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.Description = "Select the folder for the journals! If it is not created then create it!";
            dlg.ShowNewFolderButton = true;
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    JournalsFolder = null;
                    JournalsFolder += dlg.SelectedPath;
                    
                }
                else
                {
                    button1_Click(sender, e);
                }

            
            
            

            
            
            


           
            // If the directory doesn't exist, create it.
            if (!Directory.Exists(JournalsFolder))
            {
                Directory.CreateDirectory(JournalsFolder);
                string TXTfileName = DateTime.Now.ToString("dd.MM.yyyy");//EVERY JOURNAL TXT FILE WILL BE NAMED BY THE DAY IN WHICH IT IS CREATED
                string Location = $@"{JournalsFolder}\{TXTfileName}.txt";
                if (!File.Exists(Location))
                {
                    using (StreamWriter sw = File.CreateText(Location))//IF THE CURRENT DAY TXT FILE IS NOT CREATED THEN CREATE IT
                    {
                        
                        conn.Open();
                        string query = "INSERT INTO JournalLocations(Account,Date,Location) VALUES('"+UserName.Trim() + "','"+TXTfileName.Trim() + "','"+Location.Trim() + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();//SAVE THE NAME OF THE FILE AND IT'S LOCATION UNDER THE ACCOUNT NAME IN THE DATABASE
                        //THIS IS IF YOU ARE PLANNING TO SAVE SOMETHING TO A DATABASE.

                        sw.WriteLine(richTextBox1.Text);
                        sw.Close();
                    }
                }
                else if(File.Exists(Location))
                {
                    string readText = File.ReadAllText(Location);//IF THE FILE FOR A SPECIFIC DAY ALREADY EXISTS YOU CAN OPEN IT DIRECTLY, THE APP NOT LETTING YOU CREATE MULTIPLE TXT FILES FOR THE SAME DAY.
                    richTextBox1.Text = readText;
                }
            }
            else if(Directory.Exists(JournalsFolder))
            {
                string TXTfileName = DateTime.Now.ToString("dd.MM.yyyy");
                string Location = $@"{JournalsFolder}\{TXTfileName}.txt";
                if (!File.Exists(Location))
                {
                    using (StreamWriter sw = File.CreateText(Location))
                    {
                        
                        conn.Open();
                        string query = "INSERT INTO JournalLocations(Account,Date,Location) VALUES('" + UserName.Trim() + "','" + TXTfileName.Trim() + "','" + Location.Trim() + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //THIS IS IF YOU ARE PLANNING TO SAVE SOMETHING TO A DATABASE.
                        sw.WriteLine(richTextBox1.Text);
                        sw.Close();
                    }
                }
                else if (File.Exists(Location))
                {
                    string readText = File.ReadAllText(Location);
                    richTextBox1.Text = readText;
                }

            }
            
            
            
        }

        
        
    }
}
