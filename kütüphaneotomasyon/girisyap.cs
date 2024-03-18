using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kütüphaneotomasyon
{
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand kontrol = new SqlCommand("Select * From personel where pKadi=@p1 and " + "pSifre=@p2", sqlconnection.connection);

            sqlconnection.CheckConnection();

            kontrol.Parameters.AddWithValue("@p1", txtkadi.Text);
            kontrol.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = kontrol.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("HOŞ GELDİNİZ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                anasayfa home = new anasayfa(); 
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı !!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            sqlconnection.CloseConnection();

            txtkadi.Text = string.Empty;
            txtsifre.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitol frm = new kayitol();  
            frm.Show();
            this.Hide();
        }

        private void chcSifre_CheckedChanged(object sender, EventArgs e)
        {
            txtsifre.PasswordChar = chcSifre.Checked ? '\0' : '*'; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        

        private void girisyap_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void girisyap_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void girisyap_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
