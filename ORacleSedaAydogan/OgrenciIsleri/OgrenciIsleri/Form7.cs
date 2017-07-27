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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public void veriGetir()
        {

            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand("SELECT ID,DERSADI,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID,ADI,SOYADI FROM  TBLOGRENCINOT INNER JOIN TBLDERS ON TBLOGRENCINOT.DERSID=TBLDERS.DERSID INNER JOIN TBLOGRENCI ON TBLOGRENCINOT.OGRENCI_ID=TBLOGRENCI.IDOGRENCI", conn);
                DataTable TBLDRS = new DataTable();
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
        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

       

        private void Form7_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");

            OracleCommand cmd = new OracleCommand("SELECT ID,DERSADI,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID,ADI,SOYADI FROM  TBLOGRENCINOT INNER JOIN TBLDERS ON TBLOGRENCINOT.DERSID=TBLDERS.DERSID INNER JOIN TBLOGRENCI ON TBLOGRENCINOT.OGRENCI_ID=TBLOGRENCI.IDOGRENCI  WHERE ADI LIKE  '%" + textBox1.Text + "%'", conn);
            System.Data.DataTable tbl = new System.Data.DataTable();
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width,this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm,new Rectangle(0,0,this.dataGridView1.Width,this.dataGridView1.Height));
            e.Graphics.DrawImage(bm,10,10);
        }
    }
}
