namespace kütüphaneotomasyon
{
    partial class kullaniciyonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciyonetimi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullaniciTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet3 = new kütüphaneotomasyon.db_kutuphaneDataSet3();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_kutuphaneDataSet = new kütüphaneotomasyon.db_kutuphaneDataSet();
            this.btnekle = new System.Windows.Forms.Button();
            this.kullaniciTableAdapter = new kütüphaneotomasyon.db_kutuphaneDataSetTableAdapters.kullaniciTableAdapter();
            this.dbkutuphaneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter1 = new kütüphaneotomasyon.db_kutuphaneDataSet3TableAdapters.kullaniciTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.kitapYönetimiToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(86, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Yönetim Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "T.C Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adres:";
            // 
            // txttc
            // 
            this.txttc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttc.Location = new System.Drawing.Point(200, 96);
            this.txttc.Multiline = true;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(181, 31);
            this.txttc.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtad.Location = new System.Drawing.Point(200, 140);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(181, 31);
            this.txtad.TabIndex = 8;
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsoyad.Location = new System.Drawing.Point(200, 183);
            this.txtsoyad.Multiline = true;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(181, 31);
            this.txtsoyad.TabIndex = 9;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttel.Location = new System.Drawing.Point(200, 227);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(181, 31);
            this.txttel.TabIndex = 10;
            // 
            // txtadres
            // 
            this.txtadres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadres.Location = new System.Drawing.Point(200, 274);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(181, 77);
            this.txtadres.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullaniciTcDataGridViewTextBoxColumn,
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.kullaniciSoyadDataGridViewTextBoxColumn,
            this.kullaniciTelDataGridViewTextBoxColumn,
            this.kullaniciAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // kullaniciTcDataGridViewTextBoxColumn
            // 
            this.kullaniciTcDataGridViewTextBoxColumn.DataPropertyName = "kullaniciTc";
            this.kullaniciTcDataGridViewTextBoxColumn.HeaderText = "kullaniciTc";
            this.kullaniciTcDataGridViewTextBoxColumn.Name = "kullaniciTcDataGridViewTextBoxColumn";
            this.kullaniciTcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdDataGridViewTextBoxColumn
            // 
            this.kullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.HeaderText = "kullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.Name = "kullaniciAdDataGridViewTextBoxColumn";
            this.kullaniciAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciSoyadDataGridViewTextBoxColumn
            // 
            this.kullaniciSoyadDataGridViewTextBoxColumn.DataPropertyName = "kullaniciSoyad";
            this.kullaniciSoyadDataGridViewTextBoxColumn.HeaderText = "kullaniciSoyad";
            this.kullaniciSoyadDataGridViewTextBoxColumn.Name = "kullaniciSoyadDataGridViewTextBoxColumn";
            this.kullaniciSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciTelDataGridViewTextBoxColumn
            // 
            this.kullaniciTelDataGridViewTextBoxColumn.DataPropertyName = "kullaniciTel";
            this.kullaniciTelDataGridViewTextBoxColumn.HeaderText = "kullaniciTel";
            this.kullaniciTelDataGridViewTextBoxColumn.Name = "kullaniciTelDataGridViewTextBoxColumn";
            this.kullaniciTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdresDataGridViewTextBoxColumn
            // 
            this.kullaniciAdresDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAdres";
            this.kullaniciAdresDataGridViewTextBoxColumn.HeaderText = "kullaniciAdres";
            this.kullaniciAdresDataGridViewTextBoxColumn.Name = "kullaniciAdresDataGridViewTextBoxColumn";
            this.kullaniciAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciBindingSource1
            // 
            this.kullaniciBindingSource1.DataMember = "kullanici";
            this.kullaniciBindingSource1.DataSource = this.db_kutuphaneDataSet3;
            // 
            // db_kutuphaneDataSet3
            // 
            this.db_kutuphaneDataSet3.DataSetName = "db_kutuphaneDataSet3";
            this.db_kutuphaneDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "kullanici";
            this.kullaniciBindingSource.DataSource = this.db_kutuphaneDataSet;
            // 
            // db_kutuphaneDataSet
            // 
            this.db_kutuphaneDataSet.DataSetName = "db_kutuphaneDataSet";
            this.db_kutuphaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(453, 201);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(103, 54);
            this.btnekle.TabIndex = 13;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // dbkutuphaneDataSetBindingSource
            // 
            this.dbkutuphaneDataSetBindingSource.DataSource = this.db_kutuphaneDataSet;
            this.dbkutuphaneDataSetBindingSource.Position = 0;
            // 
            // kullaniciTableAdapter1
            // 
            this.kullaniciTableAdapter1.ClearBeforeFill = true;
            // 
            // kullaniciyonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 539);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "kullaniciyonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Yönetim";
            this.Load += new System.EventHandler(this.kullaniciyonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_kutuphaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbkutuphaneDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapYönetimiToolStripMenuItem;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private db_kutuphaneDataSet db_kutuphaneDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private db_kutuphaneDataSetTableAdapters.kullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.BindingSource dbkutuphaneDataSetBindingSource;
        private db_kutuphaneDataSet3 db_kutuphaneDataSet3;
        private System.Windows.Forms.BindingSource kullaniciBindingSource1;
        private db_kutuphaneDataSet3TableAdapters.kullaniciTableAdapter kullaniciTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdresDataGridViewTextBoxColumn;
    }
}