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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }



        private void btnkayit_Click(object sender, EventArgs e)
        {

            SqlCommand ekle = new SqlCommand("INSERT into personel(pTc,pAd,pSoyad,pTel,pAdres,pKadi,pSifre) values " +
                "(@ptc,@pad,@psoyad,@ptel,@padres,@pkadi,@psifre)", sqlconnection.connection);

            sqlconnection.CheckConnection();

            ekle.Parameters.AddWithValue("@ptc", txttc.Text);
            ekle.Parameters.AddWithValue("@pad", txtad.Text);
            ekle.Parameters.AddWithValue("@psoyad", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@ptel", txttel.Text);
            ekle.Parameters.AddWithValue("@padres", txtadres.Text);
            ekle.Parameters.AddWithValue("@pkadi", txtkadi.Text);
            ekle.Parameters.AddWithValue("@psifre", txtsifre.Text);


            ekle.ExecuteNonQuery();

            sqlconnection.CloseConnection();
            MessageBox.Show("Personel başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txttc.Text = string.Empty;
            txtad.Text = string.Empty;
            txtsoyad.Text = string.Empty;
            txttel.Text = string.Empty;
            txtadres.Text = string.Empty;
            txtkadi.Text = string.Empty;
            txtsifre.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            girisyap frm = new girisyap(); 
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();   

        }
    }
}
