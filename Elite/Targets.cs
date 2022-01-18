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
    public partial class Targets : Form
    {
        public string UserName { get; set; }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E39HUGAJ;Initial Catalog=EliteDB;Integrated Security=True");
        public Targets()
        {
            InitializeComponent();
        }

        private void Targets_Load(object sender, EventArgs e)
        {
            string user = UserName;//ASA S-A TRANSFERAT USERNAME-UL DIN FORM1.

            //THIS FORM WILL CONTAIN THE USER'S 
        }
    }
}
