using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MikulasCsomagEditor
{
    public partial class FrmMain : Form
    {
        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" +
            @"AttachDbFileName=|DataDirectory|Resources\mikulas.mdf;";
        static SqlConnection connection = new SqlConnection(connectionString);
        public FrmMain()
        {
            InitializeComponent();
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan ki akar lépni?","Kilépne?", MessageBoxButtons.YesNo);
            switch (valasz)
            {
                case DialogResult.Yes:
                    FrmMain.ActiveForm.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOsztaly frm = new FrmOsztaly(connectionString);
            frm.ShowDialog();
        }

        private void sorsolas_Click(object sender, EventArgs e)
        {
            FrmSorsolas frm = new FrmSorsolas(connectionString);
            frm.ShowDialog();
        }

        private void epito_Click(object sender, EventArgs e)
        {
            FrmCsomagEpito frm = new FrmCsomagEpito(connectionString);
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
