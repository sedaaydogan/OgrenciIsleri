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
using System.IO;

namespace OgrenciIsleri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bolumGetir()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select BOLUMADI from TBLBOLUM ORDER BY BOLUMID", conn);
            DataTable TBLBLM = new DataTable();

            try
            {

                conn.Open();
                TBLBLM.Load(cmd.ExecuteReader());

                for (int i = 0; i < TBLBLM.Rows.Count; i++)
                {
                    cmbbolum.Items.Add(TBLBLM.Rows[i]["BOLUMADI"]);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT TCNO,ADI,SOYADI,KAYITTARIHI,BOLUMADI,SINIF,ADRES,CEPTEL,DOGUMTARIHI,IDOGRENCI FROM TBLOGRENCI INNER JOIN TBLBOLUM ON TBLOGRENCI.BOLUMID = TBLBOLUM.BOLUMID", conn);
            DataTable TBLOGRNCI = new DataTable();

            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLOGRNCI.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = TBLOGRNCI;
                txttc.Focus();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            bolumGetir();
            veriGetir();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        
                

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select BOLUMID from TBLBOLUM WHERE BOLUMADI='" + cmbbolum.Text + "'", conn);
            DataTable TBLBLM = new DataTable();
          
            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLBLM.Load(cmd.ExecuteReader());
                
                if (TBLBLM.Rows.Count > 0)
                {
                    cmd.CommandText = "insert into TBLOGRENCI(TCNO,ADI,SOYADI,KAYITTARIHI,BOLUMID,SINIF,ADRES,CEPTEL,DOGUMTARIHI,IDOGRENCI) values( '" + txttc.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "'," + Convert.ToInt32(TBLBLM.Rows[0][0]) + ",'" + cmbsinif.SelectedItem.ToString() + "','" + txtadres.Text + "','" + maskedTextBox1.Text + "','" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "',seq_id.NEXTVAL)";
                    cmd.ExecuteNonQuery();
                   
                  veriGetir();
                }
                conn.Close();
                txttc.Clear();
                txtad.Clear();
                txtadres.Clear();
                //txtogrencino.Clear();
                txtsoyad.Clear();
                txtresimyolu.Clear();
                txttc.Focus();
                maskedTextBox1.Clear();
                MessageBox.Show("Kayit Başarıyla eklendi!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string tcno = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            string adi = dataGridView1.Rows[secilenalan].Cells[1].Value.ToString();
            string soyadi = dataGridView1.Rows[secilenalan].Cells[2].Value.ToString();
            //string ogrencino = dataGridView1.Rows[secilenalan].Cells[3].Value.ToString();
            string kayittarih = dataGridView1.Rows[secilenalan].Cells[3].Value.ToString();
            string bolum = dataGridView1.Rows[secilenalan].Cells[4].Value.ToString();
            string sinif = dataGridView1.Rows[secilenalan].Cells[5].Value.ToString();
            string adres = dataGridView1.Rows[secilenalan].Cells[6].Value.ToString();
            string cepno = dataGridView1.Rows[secilenalan].Cells[7].Value.ToString();
            string d_tarih = dataGridView1.Rows[secilenalan].Cells[8].Value.ToString();
            string ogrenciid = dataGridView1.Rows[secilenalan].Cells[9].Value.ToString();
            

            dateTimePicker1.Text = kayittarih;
            txttc.Text = tcno;
            txtad.Text = adi;
            txtsoyad.Text = soyadi;
            cmbbolum.Text = bolum;
            //txtogrencino.Text = ogrencino;
            cmbsinif.Text = sinif;
            txtadres.Text = adres;
            maskedTextBox1.Text = cepno;
            dateTimePicker2.Text = d_tarih;
            txtogrenciid.Text = ogrenciid;
          
 
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from TBLOGRENCI where IDOGRENCI='" + txtogrenciid.Text + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    veriGetir();
                    conn.Close();
                    txttc.Clear();
                    txtad.Clear();
                    txtadres.Clear();
                    txtogrencino.Clear();
                    txtsoyad.Clear();
                    txtogrenciid.Clear();
                    maskedTextBox1.Clear();
                    dataGridView1.Focus();

                    MessageBox.Show("Kayıt Başarıyla Silindi!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {

                string bolum = cmbbolum.SelectedItem.ToString();
                //string sinif = cmbsinif.SelectedItem.ToString();
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("select BOLUMID from TBLBOLUM WHERE BOLUMADI='" + bolum + "'", conn);
                DataTable TBLBLM = new DataTable();
                TBLBLM.Load(cmd1.ExecuteReader());
                cmd1.CommandText = "UPDATE TBLOGRENCI SET TCNO='" + txttc.Text + "',ADI='" + txtad.Text + "',SOYADI='" + txtsoyad.Text + "',KAYITTARIHI='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "',BOLUMID=" + TBLBLM.Rows[0][0] + ",SINIF='" + cmbsinif.SelectedItem.ToString() +"',ADRES='" + txtadres.Text + "',CEPTEL='" + maskedTextBox1.Text + "',DOGUMTARIHI='" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' WHERE IDOGRENCI='" + txtogrenciid.Text + "'";

                // conn.Open();
                cmd1.ExecuteNonQuery();
                veriGetir();
                conn.Close();
                txttc.Clear();
                txtad.Clear();
                txtadres.Clear();
                //txtogrencino.Clear();
                txtsoyad.Clear();
                txtogrenciid.Clear();
                maskedTextBox1.Clear();
                dataGridView1.Focus();

                MessageBox.Show("Güncelleme Başarıyle gerçekleşti!!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtresimyolu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
