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
    public partial class Form6 : Form
    {
        public Form6()
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
        private void ogrenciNoGetir()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT IDOGRENCI FROM TBLOGRENCI ORDER BY IDOGRENCI", conn);
           
            DataTable TBLBLM = new DataTable();

            try
            {

                conn.Open();
                TBLBLM.Load(cmd.ExecuteReader());
                for (int i = 0; i < TBLBLM.Rows.Count; i++)
                {
                    cmbogrencino.Items.Add(TBLBLM.Rows[i]["IDOGRENCI"]);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void dersGetir()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            cmbdersadi.Items.Clear();
                OracleCommand cmd = new OracleCommand("SELECT DERSADI FROM TBLDERS INNER JOIN TBLBOLUM ON TBLDERS.BOLUMID=TBLBOLUM.BOLUMID INNER JOIN TBLOGRENCI ON TBLBOLUM.BOLUMID=TBLOGRENCI.BOLUMID WHERE TBLOGRENCI.IDOGRENCI=" +cmbogrencino.Text + "", conn);

                DataTable TBLBLM = new DataTable();

                try
                {

                    conn.Open();

                    TBLBLM.Load(cmd.ExecuteReader());

                    for (int i = 0; i < TBLBLM.Rows.Count; i++)
                    {
                        cmbdersadi.Items.Add(TBLBLM.Rows[i]["DERSADI"]);
                    }

                    conn.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ogrenciNoGetir();
            veriGetir();
        }

        private void cmbogrencino_SelectedIndexChanged(object sender, EventArgs e)
        {
            dersGetir();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int vize, final;
            int a, b, ort;
            vize = Convert.ToInt32(txtvize.Text);
            final = Convert.ToInt32(txtfinal.Text);
            a = (vize * 40) / 100;
            b = (final * 60) / 100;
           ort = a + b;
           txtortalama.Text = ort.ToString();
          
            if(ort>84)
            {
                txtharfnotu.Text = "AA";
            }
            else if (ort > 74) 
            {
                txtharfnotu.Text = "BA";
            }
            else if(ort>69)
            {
            
                txtharfnotu.Text="BB";
            }
            else if(ort>65)
            {
                txtharfnotu.Text = "CB";
             }
            else if (ort > 59)
            {
                txtharfnotu.Text = "CC";
            }
            else if (ort > 54)
            {
                txtharfnotu.Text = "DC";
            }
            else if (ort > 49)
            {
                txtharfnotu.Text = "DD";
            }
            else {
                txtharfnotu.Text = "FF";
            }


            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select IDOGRENCI from TBLOGRENCI WHERE IDOGRENCI='" + cmbogrencino.Text + "'", conn);
            DataTable TBLBLM = new DataTable();

            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLBLM.Load(cmd.ExecuteReader());

                if (TBLBLM.Rows.Count > 0)
                {
                    cmd.CommandText = "SELECT DERSID FROM TBLDERS WHERE DERSADI='"+cmbdersadi.Text+"' ";
                    DataTable TBLDRS = new DataTable();
                    TBLDRS.Load(cmd.ExecuteReader());
                    cmd.CommandText = "insert into TBLOGRENCINOT(ID,DERSID,VIZE,FINAL,ORTALAMA,HARF,OGRENCI_ID) values( seq_id.NEXTVAL," + Convert.ToInt32(TBLDRS.Rows[0][0]) + "," + Convert.ToInt32(txtvize.Text) + "," + Convert.ToInt32(txtfinal.Text) + "," + Convert.ToInt32(txtortalama.Text) + ",'" + txtharfnotu.Text + "'," + Convert.ToInt32(TBLBLM.Rows[0][0]) + ")";

                    cmd.ExecuteNonQuery();
                    veriGetir();
                }
                conn.Close();
               // txtharfnotu.Clear();
                txtvize.Clear();
                txtfinal.Clear();
               // txtortalama.Clear();
                //txtsoyad.Clear();
                //txtresimyolu.Clear();
                //txttc.Focus();
                //maskedTextBox1.Clear();
                MessageBox.Show("Kayit Başarıyla eklendi!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtortalama_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from TBLOGRENCINOT where ID='" + txtnotid.Text + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    veriGetir();
                    conn.Close();
                    txtadi.Clear();
                    txtfinal.Clear();
                    txtvize.Clear();
                    txtharfnotu.Clear();
                    txtortalama.Clear();
                    txtsoyad.Clear();
                    txtogrenciid.Clear();
                    
                    dataGridView1.Focus();

                    MessageBox.Show("Kayıt Başarıyla Silindi!!!!");
                }
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
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string notid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            string dersid = dataGridView1.Rows[secilenalan].Cells[1].Value.ToString();
            string vize = dataGridView1.Rows[secilenalan].Cells[2].Value.ToString();
            string final = dataGridView1.Rows[secilenalan].Cells[3].Value.ToString();
            string ort = dataGridView1.Rows[secilenalan].Cells[4].Value.ToString();
            string harf = dataGridView1.Rows[secilenalan].Cells[5].Value.ToString();
            string ogrenciid = dataGridView1.Rows[secilenalan].Cells[6].Value.ToString();
            string adi = dataGridView1.Rows[secilenalan].Cells[7].Value.ToString();
            string soyadi = dataGridView1.Rows[secilenalan].Cells[8].Value.ToString();

            txtnotid.Text = notid;
            cmbdersadi.Text = dersid;
            txtvize.Text = vize;
            txtfinal.Text = final;
            txtortalama.Text = ort;
            txtharfnotu.Text = harf;
            cmbogrencino.Text = ogrenciid;
            txtadi.Text = adi;
            txtsoyad.Text = soyadi;
           

        }

        
       
    }
}
