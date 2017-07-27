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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
                OracleCommand cmd = new OracleCommand("YENI", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("STU_ID", OracleDbType.Int32).Value = textBox1.Text;
                cmd.Parameters.Add("STU_SINIF", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("STU_TC", OracleDbType.Int32).Direction = ParameterDirection.Output;

                //cmd.Parameters["STD_ADI"].Size = 5;
                //cmd.Parameters["STD_SOYADI"].Size = 4;
                conn.Open();
                cmd.ExecuteNonQuery();
                textBox2.Text = cmd.Parameters["STU_SINIF"].Value.ToString();
                textBox3.Text = cmd.Parameters["STU_TC"].Value.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
