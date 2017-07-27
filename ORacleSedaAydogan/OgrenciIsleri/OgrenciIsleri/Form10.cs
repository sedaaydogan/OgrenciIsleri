using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace OgrenciIsleri
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void listele()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select * from SILINBOLUM ", conn);
            DataTable TBLBLM = new DataTable();

            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLBLM.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = TBLBLM;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
