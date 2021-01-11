using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmOsztaly : Form
    {
        string connectionString;
        SqlConnection connection;
        public FrmOsztaly(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
            InitializeComponent();
        }
        
        private void tallozas_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            tallozasTB.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        private void tallozasTB_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(tallozasTB.Text))
            {
                osztalyTB.ReadOnly = false;
                hozzaadas.Enabled = true;
            }
            else
            {
                osztalyTB.ReadOnly = true;
                hozzaadas.Enabled = false;
            }
        }

        private void hozzaadas_Click(object sender, EventArgs e)
        {
            using(StreamReader sr = new StreamReader(tallozasTB.Text))
            {
                connection.Open();
                while (!sr.EndOfStream)
                {
                    int command = new SqlCommand($"insert into emberek values('{sr.ReadLine()}', '{osztalyTB.Text}');", connection).ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
