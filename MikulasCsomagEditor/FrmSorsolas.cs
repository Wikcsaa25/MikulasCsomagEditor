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

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> emberek = new Dictionary<int, string>();
            List<int> kapott = new List<int>();
            connection.Open();
            SqlDataReader comm = new SqlCommand($"select id, nev from emberek where osztaly like '{osztalyCB.SelectedItem}';", connection).ExecuteReader();
            while (comm.Read())
            {
                emberek.Add((int)comm[0], (string)comm[1]);
            }
            connection.Close();
            Random rnd = new Random();
            dgwSorsolva.Rows.Clear();
            int[] emberId = new int[emberek.Count];
            emberek.Keys.CopyTo(emberId, 0);
            foreach (KeyValuePair<int,string> item in emberek)
            {
                int valasztott = rnd.Next(0, emberId.Length);
                while (kapott.Contains(emberId[valasztott]) || emberId[valasztott] == item.Key)
                {
                    valasztott = rnd.Next(0, emberId.Length);
                }
                dgwSorsolva.Rows.Add(item.Key, item.Value, emberId[valasztott], emberek[emberId[valasztott]]);
                kapott.Add(emberId[valasztott]);
            }
            csere.Enabled = true;
            veglegesit.Enabled = true;
        }

        private void veglegesit_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgwSorsolva.Rows.Count; i++)
            {
                connection.Open();
                SqlDataReader sqlCommand = new SqlCommand($"insert into csomagok (kitol, kinek, ev)" +
                $" values('{dgwSorsolva.Rows[i].Cells[0].Value}','{dgwSorsolva.Rows[i].Cells[2].Value}', {(int)DateTime.Now.Year});", connection).ExecuteReader();
                connection.Close();
            }
            FrmSorsolas.ActiveForm.Close();
        }
    }
}
