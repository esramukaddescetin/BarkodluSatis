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
            this.tStandart1 = new BarkodluSatis.tStandart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BTNUrunGrubuEkle = new BarkodluSatis.bStandart();
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
            // tStandart1
            // 
            this.tStandart1.BackColor = System.Drawing.Color.White;
            this.tStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tStandart1.Location = new System.Drawing.Point(12, 58);
            this.tStandart1.Name = "tStandart1";
            this.tStandart1.Size = new System.Drawing.Size(250, 26);
            this.tStandart1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 164);
            this.listBox1.TabIndex = 2;
            // 
            // BTNUrunGrubuEkle
            // 
            this.BTNUrunGrubuEkle.BackColor = System.Drawing.Color.Tan;
            this.BTNUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tan;
            this.BTNUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.BTNUrunGrubuEkle.Image = ((System.Drawing.Image)(resources.GetObject("BTNUrunGrubuEkle.Image")));
            this.BTNUrunGrubuEkle.Location = new System.Drawing.Point(12, 278);
            this.BTNUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.BTNUrunGrubuEkle.Name = "BTNUrunGrubuEkle";
            this.BTNUrunGrubuEkle.Size = new System.Drawing.Size(250, 74);
            this.BTNUrunGrubuEkle.TabIndex = 3;
            this.BTNUrunGrubuEkle.Text = "Ekle";
            this.BTNUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNUrunGrubuEkle.UseVisualStyleBackColor = false;
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 369);
            this.Controls.Add(this.BTNUrunGrubuEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tStandart1);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubuEkle";
            this.Text = "Ürün Grubu İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart tStandart1;
        private System.Windows.Forms.ListBox listBox1;
        private bStandart BTNUrunGrubuEkle;
    }
}