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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //label2.Text = status;
        }
       
        
        Form11 f11=(Form11)Application.OpenForms["Form11"];
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşçakal..");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(f11.yetki.ToString(),"Ogrenci Isleri");
            if(f11.yetki=="0")
            {

               // MessageBox.Show("Yönetici olarak Giris Yaptınız !!!");
                
            }
            if (f11.yetki == "3")
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button6.Hide();
                button8.Hide();
                button10.Hide();
            }
            if (f11.yetki == "1") 
            {
                button1.Hide();
                button6.Hide();
                button10.Hide();
            }
            if(f11.yetki=="2")
            {
                button1.Hide();
                button2.Hide();
                button6.Hide();
                button10.Hide();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }

       
        private void button9_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Hide();
        }
    }
}
