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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }


        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT ID,DERSADI,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID,ADI,SOYADI FROM  TBLOGRENCINOT INNER JOIN TBLDERS ON TBLOGRENCINOT.DERSID=TBLDERS.DERSID INNER JOIN TBLOGRENCI ON TBLOGRENCINOT.OGRENCI_ID=TBLOGRENCI.IDOGRENCI", conn);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
    }
}
