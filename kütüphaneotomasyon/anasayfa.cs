﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphaneotomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kitapyonetimi frm = new kitapyonetimi(); 
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciyonetimi frm =new kullaniciyonetimi(); 
            frm.Show(); 
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelyonetimi frm =new personelyonetimi(); 
            frm.Show();
            this.Hide();
        }
    }
}
