using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Oracle.ManagedDataAccess.Client;

namespace OgrenciIsleri
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT ID,DERSADI,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID,ADI,SOYADI FROM  TBLOGRENCINOT INNER JOIN TBLDERS ON TBLOGRENCINOT.DERSID=TBLDERS.DERSID INNER JOIN TBLOGRENCI ON TBLOGRENCINOT.OGRENCI_ID=TBLOGRENCI.IDOGRENCI", conn);
            //DataTable TBLDERS = new DataTable();
           

            try
            {
                System.Data.DataTable tbl = new System.Data.DataTable();
                conn.Open();
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = tbl;
                //conn.Open();
                //// dataGridView1.AutoGenerateColumns = false;
                //TBLDRS.Load(cmd.ExecuteReader());
                //dataGridView1.DataSource = TBLDRS;
                //conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
         private void txtara_TextChanged(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");

            OracleCommand cmd = new OracleCommand("SELECT ID,DERSADI,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID,ADI,SOYADI FROM  TBLOGRENCINOT INNER JOIN TBLDERS ON TBLOGRENCINOT.DERSID=TBLDERS.DERSID INNER JOIN TBLOGRENCI ON TBLOGRENCINOT.OGRENCI_ID=TBLOGRENCI.IDOGRENCI  WHERE IDOGRENCI LIKE  '%" + txtara.Text + "%'", conn);
           System.Data.DataTable tbl = new System.Data.DataTable();
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = tbl;

        }

         private void Form8_Load(object sender, EventArgs e)
         {
             veriGetir();
         }

         private void button1_Click(object sender, EventArgs e)
         {
             Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
             Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
             Worksheet ws=(Worksheet)Excel.ActiveSheet;
             Excel.Visible=true;
             ws.Cells[1, 1] = "ID";
             ws.Cells[1, 2]="DERSADI";
             ws.Cells[1, 3] = "VIZE";
             ws.Cells[1, 4] = "FINAL";
             ws.Cells[1, 5] = "ORTALAMA";
             ws.Cells[1, 6] = "HARF";
             ws.Cells[1, 7] = "OGRENCI_ID";
             ws.Cells[1, 8] = "ADI";
             ws.Cells[1, 9] = "SOYADI";

             for (int j = 2; j <= dataGridView1.Rows.Count;j++ )
             {

                 for (int i = 2; i <= 9;i++ )
                 {
                     ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                 }

             }
         }

         private void btndon_Click(object sender, EventArgs e)
         {
             Form2 frm = new Form2();
             frm.Show();
             this.Hide();
         }
        
    }
}
