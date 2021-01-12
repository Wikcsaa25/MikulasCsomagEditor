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
    
    public partial class FrmCsomagEpito : Form
    {
        string connectionString;
        SqlConnection connection;
        public FrmCsomagEpito(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void FrmCsomagEpito_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand("select nev from belevalok;",connection).ExecuteReader();
            while (command.Read())
            {
                termekCB.Items.Add(command[0]);
            }
            connection.Close();
        }

        private void azon_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(azon.Text))
            {
                connection.Open();
                SqlDataReader sqlcomm = new SqlCommand($"select id from emberek where id like {azon.Text}", connection).ExecuteReader();
                if (sqlcomm.HasRows)
                {
                    betesz.Enabled = true;
                    statisztika.Enabled = true;
                    vasarlasa.Enabled = true;
                }
                else
                {
                    betesz.Enabled = false;
                    statisztika.Enabled = false;
                    vasarlasa.Enabled = false;
                }
                connection.Close();
            }
            else
            {
                betesz.Enabled = false;
                statisztika.Enabled = false;
                vasarlasa.Enabled = false;
            }
        }
        private int ar = 0;
        private void betesz_Click(object sender, EventArgs e)
        {
            dgwTartalom.Rows.Add(termekCB.SelectedItem, mennyiseg.Text);
            connection.Open();
            SqlDataReader sqlComm = new SqlCommand($"select egysegar from belevalok where nev like '{termekCB.SelectedItem}'",connection).ExecuteReader();
            sqlComm.Read();
            ar += (int)sqlComm[0] * int.Parse(mennyiseg.Text);
            vegOsszeg.Text = ar + " Ft";
            connection.Close();
            if (ar > ertekHatar.Value)
            {
                MessageBox.Show("Átlépted az értékhatárt!");
            }
        }
    }
}
