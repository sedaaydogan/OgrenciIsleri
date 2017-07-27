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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public void veriGetir()
        {

            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("SELECT * FROM KULLANICILAR ORDER BY KULLANICIID", conn);
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into KULLANICILAR(KULLANICIID,KADI,KSIFRE,YETKI) values( seq_id.NEXTVAL,'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem.ToString() + "')";

                conn.Open();
                cmd.ExecuteNonQuery();
                veriGetir();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Kayit Başarıyla eklendi!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from KULLANICILAR where KULLANICIID='" + txtid.Text + "'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    veriGetir();
                    conn.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    

                    MessageBox.Show("Kayıt Başarıyla Silindi!!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenalan = dataGridView1.SelectedCells[0].RowIndex;
            string kullanıcıid = dataGridView1.Rows[secilenalan].Cells[0].Value.ToString();
            string kadı = dataGridView1.Rows[secilenalan].Cells[1].Value.ToString();
            string ksifre = dataGridView1.Rows[secilenalan].Cells[2].Value.ToString();
            string yetki = dataGridView1.Rows[secilenalan].Cells[3].Value.ToString();
            txtid.Text = kullanıcıid;
            textBox1.Text = kadı;
            textBox2.Text = ksifre;
            comboBox1.Text = yetki;        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update  KULLANICILAR set KADI='" + textBox1.Text + "' , KSIFRE='" + textBox2.Text + "' ,YETKI='" + comboBox1.SelectedItem.ToString() + "' where KULLANICIID='" + txtid.Text + "'";

                conn.Open();
                cmd.ExecuteNonQuery();
                veriGetir();
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
             

                MessageBox.Show("Güncelleme Başarıyle gerçekleşti!!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

       
    }
}
