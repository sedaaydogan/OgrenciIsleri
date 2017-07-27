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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection("DATA SOURCE=DESKTOP-EHLEVPQ:1521/XE;PERSIST SECURITY INFO=True;USER ID=SEDA; PASSWORD=123456");
        public string yetki;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                bool kontrol = false;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = " select * from kullanicilar where kadi='"+textBox1.Text+"' and ksifre='"+textBox2.Text+"' ";
                OracleDataReader oku = cmd.ExecuteReader();
               while(oku.Read())
               {
                   yetki = oku["yetki"].ToString();
                   kontrol = true;
                   this.Hide();
               }
               conn.Close();
               if (kontrol == true)
               {
                   Form2 an = new Form2();
                   an.ShowDialog();
                   //an.Show();
               }
               else {
                   MessageBox.Show("lutfen bilgilerinizi kontrol ediniz!!!!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
            
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
