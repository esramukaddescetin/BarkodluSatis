namespace BarkodluSatis
{
    partial class fAyarlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TXTSifreTekrar = new BarkodluSatis.tStandart();
            this.lStandart7 = new BarkodluSatis.lStandart();
            this.TXTTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TXTSifre = new BarkodluSatis.tStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.TXTKullaniciAdi = new BarkodluSatis.tStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.TXTEPosta = new BarkodluSatis.tStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.TXTAdSoyad = new BarkodluSatis.tStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNIptal = new BarkodluSatis.bStandart();
            this.BTNKaydet = new BarkodluSatis.bStandart();
            this.lStandart8 = new BarkodluSatis.lStandart();
            this.CBSatisEkrani = new System.Windows.Forms.CheckBox();
            this.CBRapor = new System.Windows.Forms.CheckBox();
            this.CBStok = new System.Windows.Forms.CheckBox();
            this.CBUrunGiris = new System.Windows.Forms.CheckBox();
            this.CBAyarlar = new System.Windows.Forms.CheckBox();
            this.CBFiyatGuncelle = new System.Windows.Forms.CheckBox();
            this.CBYedekleme = new System.Windows.Forms.CheckBox();
            this.GRIDListeKullanici = new BarkodluSatis.gridOzel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDListeKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KULLANICI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CBYedekleme);
            this.splitContainer1.Panel1.Controls.Add(this.CBFiyatGuncelle);
            this.splitContainer1.Panel1.Controls.Add(this.CBAyarlar);
            this.splitContainer1.Panel1.Controls.Add(this.CBUrunGiris);
            this.splitContainer1.Panel1.Controls.Add(this.CBStok);
            this.splitContainer1.Panel1.Controls.Add(this.CBRapor);
            this.splitContainer1.Panel1.Controls.Add(this.CBSatisEkrani);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart8);
            this.splitContainer1.Panel1.Controls.Add(this.BTNIptal);
            this.splitContainer1.Panel1.Controls.Add(this.BTNKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.TXTSifreTekrar);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.TXTTelefon);
            this.splitContainer1.Panel1.Controls.Add(this.TXTSifre);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.TXTKullaniciAdi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.TXTEPosta);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.TXTAdSoyad);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GRIDListeKullanici);
            this.splitContainer1.Size = new System.Drawing.Size(963, 569);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 0;
            // 
            // TXTSifreTekrar
            // 
            this.TXTSifreTekrar.BackColor = System.Drawing.Color.White;
            this.TXTSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTSifreTekrar.Location = new System.Drawing.Point(40, 375);
            this.TXTSifreTekrar.Name = "TXTSifreTekrar";
            this.TXTSifreTekrar.PasswordChar = '*';
            this.TXTSifreTekrar.Size = new System.Drawing.Size(250, 26);
            this.TXTSifreTekrar.TabIndex = 5;
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart7.Location = new System.Drawing.Point(36, 352);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(91, 20);
            this.lStandart7.TabIndex = 12;
            this.lStandart7.Text = "Şifre Tekrar";
            // 
            // TXTTelefon
            // 
            this.TXTTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTTelefon.Location = new System.Drawing.Point(40, 133);
            this.TXTTelefon.Mask = "(999) 000-0000";
            this.TXTTelefon.Name = "TXTTelefon";
            this.TXTTelefon.Size = new System.Drawing.Size(250, 26);
            this.TXTTelefon.TabIndex = 1;
            // 
            // TXTSifre
            // 
            this.TXTSifre.BackColor = System.Drawing.Color.White;
            this.TXTSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTSifre.Location = new System.Drawing.Point(40, 314);
            this.TXTSifre.Name = "TXTSifre";
            this.TXTSifre.PasswordChar = '*';
            this.TXTSifre.Size = new System.Drawing.Size(250, 26);
            this.TXTSifre.TabIndex = 4;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(36, 291);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(42, 20);
            this.lStandart6.TabIndex = 9;
            this.lStandart6.Text = "Şifre";
            // 
            // TXTKullaniciAdi
            // 
            this.TXTKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.TXTKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTKullaniciAdi.Location = new System.Drawing.Point(40, 253);
            this.TXTKullaniciAdi.Name = "TXTKullaniciAdi";
            this.TXTKullaniciAdi.Size = new System.Drawing.Size(250, 26);
            this.TXTKullaniciAdi.TabIndex = 3;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(36, 230);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(93, 20);
            this.lStandart5.TabIndex = 7;
            this.lStandart5.Text = "Kullanıcı Adı";
            // 
            // TXTEPosta
            // 
            this.TXTEPosta.BackColor = System.Drawing.Color.White;
            this.TXTEPosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTEPosta.Location = new System.Drawing.Point(40, 193);
            this.TXTEPosta.Name = "TXTEPosta";
            this.TXTEPosta.Size = new System.Drawing.Size(250, 26);
            this.TXTEPosta.TabIndex = 2;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(36, 170);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(65, 20);
            this.lStandart4.TabIndex = 5;
            this.lStandart4.Text = "E Posta";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(36, 110);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(62, 20);
            this.lStandart3.TabIndex = 3;
            this.lStandart3.Text = "Telefon";
            // 
            // TXTAdSoyad
            // 
            this.TXTAdSoyad.BackColor = System.Drawing.Color.White;
            this.TXTAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTAdSoyad.Location = new System.Drawing.Point(40, 77);
            this.TXTAdSoyad.Name = "TXTAdSoyad";
            this.TXTAdSoyad.Size = new System.Drawing.Size(250, 26);
            this.TXTAdSoyad.TabIndex = 0;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(36, 54);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(78, 20);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ad Soyad";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(22, 21);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(182, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "KULLANICI İŞLEMLERİ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(611, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "YAZICI-TERAZİ-KOMİSYON";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNIptal
            // 
            this.BTNIptal.BackColor = System.Drawing.Color.DimGray;
            this.BTNIptal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BTNIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNIptal.ForeColor = System.Drawing.Color.White;
            this.BTNIptal.Image = global::BarkodluSatis.Properties.Resources.cross;
            this.BTNIptal.Location = new System.Drawing.Point(40, 414);
            this.BTNIptal.Margin = new System.Windows.Forms.Padding(1);
            this.BTNIptal.Name = "BTNIptal";
            this.BTNIptal.Size = new System.Drawing.Size(116, 65);
            this.BTNIptal.TabIndex = 12;
            this.BTNIptal.Text = "İptal";
            this.BTNIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNIptal.UseVisualStyleBackColor = false;
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.BackColor = System.Drawing.Color.Tomato;
            this.BTNKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BTNKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNKaydet.ForeColor = System.Drawing.Color.White;
            this.BTNKaydet.Image = global::BarkodluSatis.Properties.Resources.save__1_;
            this.BTNKaydet.Location = new System.Drawing.Point(174, 414);
            this.BTNKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(116, 65);
            this.BTNKaydet.TabIndex = 13;
            this.BTNKaydet.Text = "Kaydet";
            this.BTNKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNKaydet.UseVisualStyleBackColor = false;
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart8.Location = new System.Drawing.Point(305, 54);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(87, 20);
            this.lStandart8.TabIndex = 14;
            this.lStandart8.Text = "YETKİLER";
            // 
            // CBSatisEkrani
            // 
            this.CBSatisEkrani.AutoSize = true;
            this.CBSatisEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBSatisEkrani.Location = new System.Drawing.Point(309, 79);
            this.CBSatisEkrani.Name = "CBSatisEkrani";
            this.CBSatisEkrani.Size = new System.Drawing.Size(113, 24);
            this.CBSatisEkrani.TabIndex = 6;
            this.CBSatisEkrani.Text = "Satış Ekranı";
            this.CBSatisEkrani.UseVisualStyleBackColor = true;
            // 
            // CBRapor
            // 
            this.CBRapor.AutoSize = true;
            this.CBRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBRapor.Location = new System.Drawing.Point(309, 109);
            this.CBRapor.Name = "CBRapor";
            this.CBRapor.Size = new System.Drawing.Size(121, 24);
            this.CBRapor.TabIndex = 7;
            this.CBRapor.Text = "Rapor Ekranı";
            this.CBRapor.UseVisualStyleBackColor = true;
            // 
            // CBStok
            // 
            this.CBStok.AutoSize = true;
            this.CBStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBStok.Location = new System.Drawing.Point(309, 139);
            this.CBStok.Name = "CBStok";
            this.CBStok.Size = new System.Drawing.Size(61, 24);
            this.CBStok.TabIndex = 8;
            this.CBStok.Text = "Stok";
            this.CBStok.UseVisualStyleBackColor = true;
            // 
            // CBUrunGiris
            // 
            this.CBUrunGiris.AutoSize = true;
            this.CBUrunGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBUrunGiris.Location = new System.Drawing.Point(309, 169);
            this.CBUrunGiris.Name = "CBUrunGiris";
            this.CBUrunGiris.Size = new System.Drawing.Size(99, 24);
            this.CBUrunGiris.TabIndex = 9;
            this.CBUrunGiris.Text = "Ürün Giriş";
            this.CBUrunGiris.UseVisualStyleBackColor = true;
            // 
            // CBAyarlar
            // 
            this.CBAyarlar.AutoSize = true;
            this.CBAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBAyarlar.Location = new System.Drawing.Point(309, 199);
            this.CBAyarlar.Name = "CBAyarlar";
            this.CBAyarlar.Size = new System.Drawing.Size(77, 24);
            this.CBAyarlar.TabIndex = 10;
            this.CBAyarlar.Text = "Ayarlar";
            this.CBAyarlar.UseVisualStyleBackColor = true;
            // 
            // CBFiyatGuncelle
            // 
            this.CBFiyatGuncelle.AutoSize = true;
            this.CBFiyatGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBFiyatGuncelle.Location = new System.Drawing.Point(309, 229);
            this.CBFiyatGuncelle.Name = "CBFiyatGuncelle";
            this.CBFiyatGuncelle.Size = new System.Drawing.Size(129, 24);
            this.CBFiyatGuncelle.TabIndex = 11;
            this.CBFiyatGuncelle.Text = "Fiyat Güncelle";
            this.CBFiyatGuncelle.UseVisualStyleBackColor = true;
            // 
            // CBYedekleme
            // 
            this.CBYedekleme.AutoSize = true;
            this.CBYedekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBYedekleme.Location = new System.Drawing.Point(309, 259);
            this.CBYedekleme.Name = "CBYedekleme";
            this.CBYedekleme.Size = new System.Drawing.Size(108, 24);
            this.CBYedekleme.TabIndex = 12;
            this.CBYedekleme.Text = "Yedekleme";
            this.CBYedekleme.UseVisualStyleBackColor = true;
            // 
            // GRIDListeKullanici
            // 
            this.GRIDListeKullanici.AllowUserToAddRows = false;
            this.GRIDListeKullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDListeKullanici.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GRIDListeKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDListeKullanici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListeKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDListeKullanici.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListeKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRIDListeKullanici.EnableHeadersVisualStyles = false;
            this.GRIDListeKullanici.Location = new System.Drawing.Point(0, 0);
            this.GRIDListeKullanici.Margin = new System.Windows.Forms.Padding(0);
            this.GRIDListeKullanici.MultiSelect = false;
            this.GRIDListeKullanici.Name = "GRIDListeKullanici";
            this.GRIDListeKullanici.ReadOnly = true;
            this.GRIDListeKullanici.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListeKullanici.RowHeadersVisible = false;
            this.GRIDListeKullanici.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListeKullanici.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GRIDListeKullanici.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.GRIDListeKullanici.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.GRIDListeKullanici.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GRIDListeKullanici.RowTemplate.Height = 32;
            this.GRIDListeKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRIDListeKullanici.Size = new System.Drawing.Size(494, 569);
            this.GRIDListeKullanici.TabIndex = 2;
            // 
            // fAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAyarlar";
            this.Text = "fAyarlar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDListeKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private tStandart TXTSifreTekrar;
        private lStandart lStandart7;
        private System.Windows.Forms.MaskedTextBox TXTTelefon;
        private tStandart TXTSifre;
        private lStandart lStandart6;
        private tStandart TXTKullaniciAdi;
        private lStandart lStandart5;
        private tStandart TXTEPosta;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private tStandart TXTAdSoyad;
        private lStandart lStandart2;
        private lStandart lStandart1;
        private bStandart BTNIptal;
        private bStandart BTNKaydet;
        private System.Windows.Forms.CheckBox CBYedekleme;
        private System.Windows.Forms.CheckBox CBFiyatGuncelle;
        private System.Windows.Forms.CheckBox CBAyarlar;
        private System.Windows.Forms.CheckBox CBUrunGiris;
        private System.Windows.Forms.CheckBox CBStok;
        private System.Windows.Forms.CheckBox CBRapor;
        private System.Windows.Forms.CheckBox CBSatisEkrani;
        private lStandart lStandart8;
        private gridOzel GRIDListeKullanici;
    }
}