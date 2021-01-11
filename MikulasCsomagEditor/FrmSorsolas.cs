using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmSorsolas : Form
    {
        string connectionString;
        SqlConnection connection;
        public FrmSorsolas(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void FrmSorsolas_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("select distinct osztaly from emberek;",connection).ExecuteReader();
            while (command.Read())
            {
                osztalyCB.Items.Add(command[0]);
            }
            connection.Close();
        }
    }
}
