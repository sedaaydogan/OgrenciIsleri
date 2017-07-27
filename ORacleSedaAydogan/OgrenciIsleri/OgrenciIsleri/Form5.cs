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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT TBLDERS.DERSID,TBLDERS.DERSADI,TBLBOLUM.BOLUMADI FROM TBLBOLUM INNER JOIN TBLDERS ON TBLBOLUM.BOLUMID = TBLDERS.BOLUMID", conn);
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
                    cmbBolum.Items.Add(TBLBLM.Rows[i]["BOLUMADI"]);
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

       

        private void Form5_Load(object sender, EventArgs e)
        {
            bolumGetir();
            veriGetir();
            
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select BOLUMID from TBLBOLUM WHERE BOLUMADI='" + cmbBolum.Text + "'", conn);
            DataTable TBLBLM = new DataTable();

            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLBLM.Load(cmd.ExecuteReader());

                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                if (TBLBLM.Rows.Count > 0)
                {
                    cmd1.CommandText = "insert into TBLDERS(DersId,BolumId,DersAdi) values( seq_id.NEXTVAL," + Convert.ToInt32(TBLBLM.Rows[0][0]) + ",'" + txtders.Text + "')";
                    cmd1.ExecuteNonQuery();
                    veriGetir();
                }

             
                MessageBox.Show("Kayit Başarıyla eklendi!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string dersid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            string dersadi = dataGridView1.Rows[secilenalan].Cells[1].Value.ToString();
            string bolumadi = dataGridView1.Rows[secilenalan].Cells[2].Value.ToString();
            txtdersid.Text = dersid;
            txtders.Text = dersadi;
            cmbBolum.Text = bolumadi;

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
                    cmd.CommandText = "Delete from TBLDERS where DERSID='" + txtdersid.Text + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    veriGetir();
                    conn.Close();
                    txtders.Clear();
                    txtdersid.Clear();
                    cmbBolum.Focus();

                    MessageBox.Show("Kayıt Başarıyla Silindi!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtdersid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnduzenle_Click(object sender, EventArgs e)
        {
            try
            {

                string bolum = cmbBolum.SelectedItem.ToString();
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                conn.Open();
                OracleCommand cmd1 = new OracleCommand("select BOLUMID from TBLBOLUM WHERE BOLUMADI='" + bolum + "'", conn);
                DataTable TBLBLM = new DataTable();
                TBLBLM.Load(cmd1.ExecuteReader());
                cmd1.CommandText = "update  TBLDERS set DERSADI='" + txtders.Text + "',BOLUMID=" + TBLBLM.Rows[0][0] + " where DERSID='" + txtdersid.Text + "'";

                // conn.Open();
                cmd1.ExecuteNonQuery();
                veriGetir();
                conn.Close();
                txtders.Clear();
                txtdersid.Clear();
                cmbBolum.Focus();

                MessageBox.Show("Güncelleme Başarıyle gerçekleşti!!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");

            OracleCommand cmd = new OracleCommand("SELECT TBLDERS.DERSID,TBLDERS.DERSADI,TBLBOLUM.BOLUMADI FROM TBLBOLUM INNER JOIN TBLDERS ON TBLBOLUM.BOLUMID = TBLDERS.BOLUMID  WHERE DERSADI LIKE  '%" + textBox1.Text + "%'", conn);
            DataTable tbl = new DataTable();
            conn.Open();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            dataGridView1.DataSource = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Hide();
        }



    }
}
