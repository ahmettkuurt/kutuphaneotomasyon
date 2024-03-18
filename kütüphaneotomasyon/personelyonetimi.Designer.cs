namespace kütüphaneotomasyon
{
    partial class personelyonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelyonetimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txtekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pKadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet2 = new kütüphaneotomasyon.db_kutuphaneDataSet2();
            this.personelTableAdapter = new kütüphaneotomasyon.db_kutuphaneDataSet2TableAdapters.personelTableAdapter();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.kitapYönetimiToolStripMenuItem,
            this.kullanıcıYönetimiToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anaSayfaToolStripMenuItem.Image")));
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // kitapYönetimiToolStripMenuItem
            // 
            this.kitapYönetimiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapYönetimiToolStripMenuItem.Image")));
            this.kitapYönetimiToolStripMenuItem.Name = "kitapYönetimiToolStripMenuItem";
            this.kitapYönetimiToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.kitapYönetimiToolStripMenuItem.Text = "Kitap Yönetimi";
            this.kitapYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kitapYönetimiToolStripMenuItem_Click);
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıYönetimiToolStripMenuItem.Image")));
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            this.kullanıcıYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıYönetimiToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Yönetim Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Personel Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(13, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Personel Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(13, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Personel Adresi:";
            // 
            // txttc
            // 
            this.txttc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttc.Location = new System.Drawing.Point(333, 101);
            this.txttc.Multiline = true;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(181, 31);
            this.txttc.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtad.Location = new System.Drawing.Point(333, 145);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(181, 31);
            this.txtad.TabIndex = 8;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsoyad.Location = new System.Drawing.Point(333, 184);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(181, 31);
            this.txtsoyad.TabIndex = 9;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttel.Location = new System.Drawing.Point(333, 221);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(181, 31);
            this.txttel.TabIndex = 10;
            // 
            // txtadres
            // 
            this.txtadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadres.Location = new System.Drawing.Point(333, 258);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(181, 109);
            this.txtadres.TabIndex = 11;
            // 
            // txtekle
            // 
            this.txtekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtekle.Location = new System.Drawing.Point(608, 224);
            this.txtekle.Name = "txtekle";
            this.txtekle.Size = new System.Drawing.Size(102, 87);
            this.txtekle.TabIndex = 12;
            this.txtekle.Text = "Ekle";
            this.txtekle.UseVisualStyleBackColor = true;
            this.txtekle.Click += new System.EventHandler(this.txtekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pTcDataGridViewTextBoxColumn,
            this.pAdDataGridViewTextBoxColumn,
            this.pSoyadDataGridViewTextBoxColumn,
            this.pTelDataGridViewTextBoxColumn,
            this.pAdresDataGridViewTextBoxColumn,
            this.pKadiDataGridViewTextBoxColumn,
            this.pSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 485);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // pTcDataGridViewTextBoxColumn
            // 
            this.pTcDataGridViewTextBoxColumn.DataPropertyName = "pTc";
            this.pTcDataGridViewTextBoxColumn.HeaderText = "pTc";
            this.pTcDataGridViewTextBoxColumn.Name = "pTcDataGridViewTextBoxColumn";
            // 
            // pAdDataGridViewTextBoxColumn
            // 
            this.pAdDataGridViewTextBoxColumn.DataPropertyName = "pAd";
            this.pAdDataGridViewTextBoxColumn.HeaderText = "pAd";
            this.pAdDataGridViewTextBoxColumn.Name = "pAdDataGridViewTextBoxColumn";
            // 
            // pSoyadDataGridViewTextBoxColumn
            // 
            this.pSoyadDataGridViewTextBoxColumn.DataPropertyName = "pSoyad";
            this.pSoyadDataGridViewTextBoxColumn.HeaderText = "pSoyad";
            this.pSoyadDataGridViewTextBoxColumn.Name = "pSoyadDataGridViewTextBoxColumn";
            // 
            // pTelDataGridViewTextBoxColumn
            // 
            this.pTelDataGridViewTextBoxColumn.DataPropertyName = "pTel";
            this.pTelDataGridViewTextBoxColumn.HeaderText = "pTel";
            this.pTelDataGridViewTextBoxColumn.Name = "pTelDataGridViewTextBoxColumn";
            // 
            // pAdresDataGridViewTextBoxColumn
            // 
            this.pAdresDataGridViewTextBoxColumn.DataPropertyName = "pAdres";
            this.pAdresDataGridViewTextBoxColumn.HeaderText = "pAdres";
            this.pAdresDataGridViewTextBoxColumn.Name = "pAdresDataGridViewTextBoxColumn";
            // 
            // pKadiDataGridViewTextBoxColumn
            // 
            this.pKadiDataGridViewTextBoxColumn.DataPropertyName = "pKadi";
            this.pKadiDataGridViewTextBoxColumn.HeaderText = "pKadi";
            this.pKadiDataGridViewTextBoxColumn.Name = "pKadiDataGridViewTextBoxColumn";
            // 
            // pSifreDataGridViewTextBoxColumn
            // 
            this.pSifreDataGridViewTextBoxColumn.DataPropertyName = "pSifre";
            this.pSifreDataGridViewTextBoxColumn.HeaderText = "pSifre";
            this.pSifreDataGridViewTextBoxColumn.Name = "pSifreDataGridViewTextBoxColumn";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.db_kutuphaneDataSet2;
            // 
            // db_kutuphaneDataSet2
            // 
            this.db_kutuphaneDataSet2.DataSetName = "db_kutuphaneDataSet2";
            this.db_kutuphaneDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsifre.Location = new System.Drawing.Point(333, 433);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(181, 31);
            this.txtsifre.TabIndex = 19;
            // 
            // txtkadi
            // 
            this.txtkadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkadi.Location = new System.Drawing.Point(333, 387);
            this.txtkadi.Multiline = true;
            this.txtkadi.Name = "txtkadi";
            this.txtkadi.Size = new System.Drawing.Size(181, 31);
            this.txtkadi.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(13, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel Şifresi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(13, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Personel Kullanıcı Adı:";
            // 
            // personelyonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtekle);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "personelyonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetim ";
            this.Load += new System.EventHandler(this.personelyonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Button txtekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_kutuphaneDataSet2 db_kutuphaneDataSet2;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private db_kutuphaneDataSet2TableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}