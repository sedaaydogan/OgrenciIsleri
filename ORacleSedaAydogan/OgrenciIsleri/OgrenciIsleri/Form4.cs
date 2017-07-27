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
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }

        private void listele() 
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select * from TBLBOLUM ORDER BY BOLUMID", conn);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtbolumid.Visible=false;
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                   OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into TBLBOLUM(BolumId,BolumAdi,TelNo,email) values( seq_id.NEXTVAL,'" + txtBolum.Text + "','" + txttel.Text + "','" + txtemail.Text + "')";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    listele();
                    conn.Close();
                    txtBolum.Clear();
                    txtemail.Clear();
                    txttel.Clear();
                    txtBolum.Focus();
                    MessageBox.Show("Kayit Başarıyla eklendi!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
              
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
            string bolumid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            string bolumadı = dataGridView1.Rows[secilenalan].Cells[1].Value.ToString();
            string telno = dataGridView1.Rows[secilenalan].Cells[2].Value.ToString();
            string email = dataGridView1.Rows[secilenalan].Cells[3].Value.ToString();
            txtbolumid.Text=bolumid;
            txtBolum.Text = bolumadı;
            txttel.Text = telno;
            txtemail.Text = email;        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update  TBLBOLUM set TELNO='"+txttel.Text+"' , EMAIL='"+txtemail.Text+"' ,BOLUMADI='"+txtBolum.Text+"' where BOLUMID='"+txtbolumid.Text+"'";

                conn.Open();
                cmd.ExecuteNonQuery();
                listele();
                conn.Close();
                txtBolum.Clear();
                txtemail.Clear();
                txttel.Clear();
                txtBolum.Focus();

                MessageBox.Show("Güncelleme Başarıyle gerçekleşti!!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbolumid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from TBLBOLUM where BOLUMID='" + txtbolumid.Text + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    listele();
                    conn.Close();
                    txtBolum.Clear();
                    txtemail.Clear();
                    txttel.Clear();
                    txtBolum.Focus();

                    MessageBox.Show("Kayıt Başarıyla Silindi!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand("BOLUM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ADBOLUM", OracleDbType.Varchar2).Value = textBox2.Text;
                cmd.Parameters.Add("TELBOLUM", OracleDbType.Int32).Direction = ParameterDirection.Output;
              //  cmd.Parameters.Add("STU_TC", OracleDbType.Int32).Direction = ParameterDirection.Output;

                //cmd.Parameters["STD_ADI"].Size = 5;
                //cmd.Parameters["STD_SOYADI"].Size = 4;
                conn.Open();
                cmd.ExecuteNonQuery();
                //textBox2.Text = cmd.Parameters["A"].Value.ToString();
                textBox1.Text = cmd.Parameters["TELBOLUM"].Value.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.Show();
            this.Hide();
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }



    }
}
