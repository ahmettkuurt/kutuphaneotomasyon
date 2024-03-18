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
    public partial class kitapyonetimi : Form
    {
        public kitapyonetimi()
        {
            InitializeComponent();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();   
            frm.Show();
            this.Hide();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullaniciyonetimi frm = new kullaniciyonetimi(); 
            frm.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("INSERT into kitap(kitapAd,kitapYazar,kitapYayınevi) values (@pad,@pyazar,@pyayin)", sqlconnection.connection);

            sqlconnection.CheckConnection();

            ekle.Parameters.AddWithValue("@pad", txtad.Text);
            ekle.Parameters.AddWithValue("@pyazar", txtyazar.Text);
            ekle.Parameters.AddWithValue("@pyayin", txtyayin.Text);

            ekle.ExecuteNonQuery();

            sqlconnection.CloseConnection();

            MessageBox.Show("Kitap başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView1.Update();

            txtad.Text = string.Empty;
            txtyazar.Text = string.Empty;
            txtyayin.Text = string.Empty;
        }

        private void kitapyonetimi_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.db_kutuphaneDataSet1.kitap);

        }

        private void txtyazar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
