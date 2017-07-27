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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
            OracleCommand cmd = new OracleCommand("select status from login where username='"+textBox3.Text+"'", conn);
            DataTable TBLBLM = new DataTable();
            
            try
            {

                conn.Open();
                // dataGridView1.AutoGenerateColumns = false;
                TBLBLM.Load(cmd.ExecuteReader());
                if (TBLBLM.Rows.Count == 1)
                {
                   // this.Hide();
                    if(TBLBLM.Rows[0][0].ToString()=="Master")
                   {
                       // Form2 f2 = new Form2();
                      //  Form2 f2 = new Form2(TBLBLM.Rows[0][0].ToString());
                      //  f2.Show();
                        Form2 frm = new Form2();
                        frm.Show();
                       this.Hide();
                   }
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
