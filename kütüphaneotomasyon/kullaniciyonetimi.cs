﻿using System;
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
    public partial class kullaniciyonetimi : Form
    {
        public kullaniciyonetimi()
        {
            InitializeComponent();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();  
            frm.Show();
            this.Hide();
        }

        private void kitapYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapyonetimi frm = new kitapyonetimi();   
            frm.Show();
            this.Hide();

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT into kullanici(kullaniciTc,kullaniciAd,kullaniciSoyad,kullaniciTel,kullaniciAdres) values (@ptc,@pad,@psoyad,@ptel,@padres)",sqlconnection.connection);

            sqlconnection.CheckConnection();

            ekle.Parameters.AddWithValue("@ptc",txttc.Text);
            ekle.Parameters.AddWithValue("@pad",txtad.Text);
            ekle.Parameters.AddWithValue("@psoyad",txtsoyad.Text);
            ekle.Parameters.AddWithValue("@ptel",txttel.Text);
            ekle.Parameters.AddWithValue("@padres",txtadres.Text);

            ekle.ExecuteNonQuery();

            sqlconnection.CloseConnection();
            
            
            MessageBox.Show("Kullanıcı başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.Update();

            txttc.Text = string.Empty;
            txtad.Text = string.Empty;
            txtsoyad.Text = string.Empty;
            txttel.Text = string.Empty;
            txtadres.Text = string.Empty;
        }

        private void kullaniciyonetimi_Load(object sender, EventArgs e)
        {
            this.kullaniciTableAdapter1.Fill(this.db_kutuphaneDataSet3.kullanici);

        }
    }
}
