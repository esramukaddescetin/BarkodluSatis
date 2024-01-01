namespace BarkodluSatis
{
    partial class fStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CBIslemTuru = new System.Windows.Forms.ComboBox();
            this.PANELTarihler = new System.Windows.Forms.Panel();
            this.DATEBitis = new System.Windows.Forms.DateTimePicker();
            this.DATEBaslangic = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.RBTumu = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.BTNAra = new BarkodluSatis.bStandart();
            this.lStandart5 = new BarkodluSatis.lStandart();
            this.lStandart4 = new BarkodluSatis.lStandart();
            this.lStandart3 = new BarkodluSatis.lStandart();
            this.lStandart2 = new BarkodluSatis.lStandart();
            this.TXTUrunAra = new BarkodluSatis.tStandart();
            this.lStandart6 = new BarkodluSatis.lStandart();
            this.GRIDListe = new BarkodluSatis.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PANELTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.BTNAra);
            this.splitContainer1.Panel1.Controls.Add(this.PANELTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(970, 515);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lStandart1);
            this.panel4.Controls.Add(this.CBIslemTuru);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 83);
            this.panel4.TabIndex = 6;
            // 
            // CBIslemTuru
            // 
            this.CBIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBIslemTuru.ForeColor = System.Drawing.Color.OrangeRed;
            this.CBIslemTuru.FormattingEnabled = true;
            this.CBIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.CBIslemTuru.Location = new System.Drawing.Point(8, 38);
            this.CBIslemTuru.Name = "CBIslemTuru";
            this.CBIslemTuru.Size = new System.Drawing.Size(244, 28);
            this.CBIslemTuru.TabIndex = 1;
            // 
            // PANELTarihler
            // 
            this.PANELTarihler.Controls.Add(this.DATEBitis);
            this.PANELTarihler.Controls.Add(this.lStandart5);
            this.PANELTarihler.Controls.Add(this.lStandart4);
            this.PANELTarihler.Controls.Add(this.DATEBaslangic);
            this.PANELTarihler.Location = new System.Drawing.Point(3, 285);
            this.PANELTarihler.Name = "PANELTarihler";
            this.PANELTarihler.Size = new System.Drawing.Size(257, 143);
            this.PANELTarihler.TabIndex = 5;
            // 
            // DATEBitis
            // 
            this.DATEBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DATEBitis.Location = new System.Drawing.Point(9, 86);
            this.DATEBitis.Name = "DATEBitis";
            this.DATEBitis.Size = new System.Drawing.Size(244, 26);
            this.DATEBitis.TabIndex = 3;
            // 
            // DATEBaslangic
            // 
            this.DATEBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DATEBaslangic.Location = new System.Drawing.Point(10, 36);
            this.DATEBaslangic.Name = "DATEBaslangic";
            this.DATEBaslangic.Size = new System.Drawing.Size(243, 26);
            this.DATEBaslangic.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lStandart3);
            this.panel2.Controls.Add(this.CBUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(3, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 68);
            this.panel2.TabIndex = 4;
            // 
            // CBUrunGrubu
            // 
            this.CBUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBUrunGrubu.FormattingEnabled = true;
            this.CBUrunGrubu.Location = new System.Drawing.Point(9, 32);
            this.CBUrunGrubu.Name = "CBUrunGrubu";
            this.CBUrunGrubu.Size = new System.Drawing.Size(244, 28);
            this.CBUrunGrubu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBUrunGrubunaGore);
            this.panel1.Controls.Add(this.lStandart2);
            this.panel1.Controls.Add(this.RBTumu);
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 112);
            this.panel1.TabIndex = 3;
            // 
            // RBUrunGrubunaGore
            // 
            this.RBUrunGrubunaGore.AutoSize = true;
            this.RBUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RBUrunGrubunaGore.ForeColor = System.Drawing.Color.DarkCyan;
            this.RBUrunGrubunaGore.Location = new System.Drawing.Point(88, 39);
            this.RBUrunGrubunaGore.Name = "RBUrunGrubunaGore";
            this.RBUrunGrubunaGore.Size = new System.Drawing.Size(169, 24);
            this.RBUrunGrubunaGore.TabIndex = 1;
            this.RBUrunGrubunaGore.TabStop = true;
            this.RBUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.RBUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // RBTumu
            // 
            this.RBTumu.AutoSize = true;
            this.RBTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RBTumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.RBTumu.Location = new System.Drawing.Point(13, 39);
            this.RBTumu.Name = "RBTumu";
            this.RBTumu.Size = new System.Drawing.Size(67, 24);
            this.RBTumu.TabIndex = 0;
            this.RBTumu.TabStop = true;
            this.RBTumu.Text = "Tümü";
            this.RBTumu.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.TXTUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GRIDListe);
            this.splitContainer2.Size = new System.Drawing.Size(699, 515);
            this.splitContainer2.SplitterDistance = 63;
            this.splitContainer2.TabIndex = 0;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.OrangeRed;
            this.lStandart1.Location = new System.Drawing.Point(8, 15);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(83, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "İşlem Türü";
            // 
            // BTNAra
            // 
            this.BTNAra.BackColor = System.Drawing.Color.Tomato;
            this.BTNAra.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BTNAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNAra.ForeColor = System.Drawing.Color.White;
            this.BTNAra.Image = ((System.Drawing.Image)(resources.GetObject("BTNAra.Image")));
            this.BTNAra.Location = new System.Drawing.Point(140, 435);
            this.BTNAra.Margin = new System.Windows.Forms.Padding(1);
            this.BTNAra.Name = "BTNAra";
            this.BTNAra.Size = new System.Drawing.Size(116, 70);
            this.BTNAra.TabIndex = 0;
            this.BTNAra.Text = "Ara";
            this.BTNAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNAra.UseVisualStyleBackColor = false;
            this.BTNAra.Click += new System.EventHandler(this.BTNAra_Click);
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(10, 63);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(85, 20);
            this.lStandart5.TabIndex = 2;
            this.lStandart5.Text = " Bitiş Tarihi";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(10, 10);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(120, 20);
            this.lStandart4.TabIndex = 1;
            this.lStandart4.Text = "Başlangıç Tarihi";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(9, 9);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(93, 20);
            this.lStandart3.TabIndex = 1;
            this.lStandart3.Text = "Ürün Grubu";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.OrangeRed;
            this.lStandart2.Location = new System.Drawing.Point(9, 16);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(114, 20);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Filtreleme Türü";
            // 
            // TXTUrunAra
            // 
            this.TXTUrunAra.BackColor = System.Drawing.Color.White;
            this.TXTUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTUrunAra.Location = new System.Drawing.Point(92, 16);
            this.TXTUrunAra.Name = "TXTUrunAra";
            this.TXTUrunAra.Size = new System.Drawing.Size(250, 26);
            this.TXTUrunAra.TabIndex = 1;
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(13, 19);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(77, 20);
            this.lStandart6.TabIndex = 0;
            this.lStandart6.Text = "Ürün Ara:";
            // 
            // GRIDListe
            // 
            this.GRIDListe.AllowUserToAddRows = false;
            this.GRIDListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GRIDListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRIDListe.EnableHeadersVisualStyles = false;
            this.GRIDListe.Location = new System.Drawing.Point(0, 0);
            this.GRIDListe.Margin = new System.Windows.Forms.Padding(0);
            this.GRIDListe.MultiSelect = false;
            this.GRIDListe.Name = "GRIDListe";
            this.GRIDListe.ReadOnly = true;
            this.GRIDListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListe.RowHeadersVisible = false;
            this.GRIDListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDListe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GRIDListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.GRIDListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.GRIDListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GRIDListe.RowTemplate.Height = 32;
            this.GRIDListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRIDListe.Size = new System.Drawing.Size(699, 448);
            this.GRIDListe.TabIndex = 2;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 515);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PANELTarihler.ResumeLayout(false);
            this.PANELTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private lStandart lStandart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox CBIslemTuru;
        private bStandart BTNAra;
        private System.Windows.Forms.Panel PANELTarihler;
        private System.Windows.Forms.DateTimePicker DATEBitis;
        private lStandart lStandart5;
        private lStandart lStandart4;
        private System.Windows.Forms.DateTimePicker DATEBaslangic;
        private System.Windows.Forms.Panel panel2;
        private lStandart lStandart3;
        private System.Windows.Forms.ComboBox CBUrunGrubu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBUrunGrubunaGore;
        private lStandart lStandart2;
        private System.Windows.Forms.RadioButton RBTumu;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart TXTUrunAra;
        private lStandart lStandart6;
        private gridOzel GRIDListe;
    }
}