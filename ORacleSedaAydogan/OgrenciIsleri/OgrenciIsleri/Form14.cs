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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT * From DERS", conn);
            DataTable TBLDRS = new DataTable();

            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLDRS.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = TBLDRS;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form14_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
