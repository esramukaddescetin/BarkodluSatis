namespace BarkodluSatis
{
    partial class fUrunGrubuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGrubuEkle));
            this.lStandart1 = new BarkodluSatis.lStandart();
            this.TXTUrunGrupAd = new BarkodluSatis.tStandart();
            this.LBUrunGrup = new System.Windows.Forms.ListBox();
            this.BTNEkle = new BarkodluSatis.bStandart();
            this.BTNSil = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(12, 20);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(120, 20);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // TXTUrunGrupAd
            // 
            this.TXTUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.TXTUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TXTUrunGrupAd.Location = new System.Drawing.Point(12, 43);
            this.TXTUrunGrupAd.Name = "TXTUrunGrupAd";
            this.TXTUrunGrupAd.Size = new System.Drawing.Size(250, 26);
            this.TXTUrunGrupAd.TabIndex = 1;
            // 
            // LBUrunGrup
            // 
            this.LBUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBUrunGrup.FormattingEnabled = true;
            this.LBUrunGrup.ItemHeight = 20;
            this.LBUrunGrup.Location = new System.Drawing.Point(12, 85);
            this.LBUrunGrup.Name = "LBUrunGrup";
            this.LBUrunGrup.Size = new System.Drawing.Size(250, 164);
            this.LBUrunGrup.TabIndex = 2;
            // 
            // BTNEkle
            // 
            this.BTNEkle.BackColor = System.Drawing.Color.SaddleBrown;
            this.BTNEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.BTNEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNEkle.ForeColor = System.Drawing.Color.White;
            this.BTNEkle.Image = ((System.Drawing.Image)(resources.GetObject("BTNEkle.Image")));
            this.BTNEkle.Location = new System.Drawing.Point(145, 262);
            this.BTNEkle.Margin = new System.Windows.Forms.Padding(1);
            this.BTNEkle.Name = "BTNEkle";
            this.BTNEkle.Size = new System.Drawing.Size(117, 74);
            this.BTNEkle.TabIndex = 3;
            this.BTNEkle.Text = "Ekle";
            this.BTNEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNEkle.UseVisualStyleBackColor = false;
            this.BTNEkle.Click += new System.EventHandler(this.BTNEkle_Click);
            // 
            // BTNSil
            // 
            this.BTNSil.BackColor = System.Drawing.Color.Orange;
            this.BTNSil.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.BTNSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNSil.ForeColor = System.Drawing.Color.White;
            this.BTNSil.Image = ((System.Drawing.Image)(resources.GetObject("BTNSil.Image")));
            this.BTNSil.Location = new System.Drawing.Point(12, 262);
            this.BTNSil.Margin = new System.Windows.Forms.Padding(1);
            this.BTNSil.Name = "BTNSil";
            this.BTNSil.Size = new System.Drawing.Size(117, 74);
            this.BTNSil.TabIndex = 4;
            this.BTNSil.Text = "Sil";
            this.BTNSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSil.UseVisualStyleBackColor = false;
            this.BTNSil.Click += new System.EventHandler(this.BTNSil_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 355);
            this.Controls.Add(this.BTNSil);
            this.Controls.Add(this.BTNEkle);
            this.Controls.Add(this.LBUrunGrup);
            this.Controls.Add(this.TXTUrunGrupAd);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart TXTUrunGrupAd;
        private System.Windows.Forms.ListBox LBUrunGrup;
        private bStandart BTNEkle;
        private bStandart BTNSil;
    }
}