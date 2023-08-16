using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarkodluSatis.Properties;
using Label = System.Windows.Forms.Label;

namespace BarkodluSatis
{
    internal class Nesnelerim
    {
    }
    //Bir class oluşturarak tasarlanmış label objesi üretmek için.
    class lStandart : Label
    {
        public lStandart()
        {
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Text = "lStandart";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "lStandart";
        }
    }
    class bStandart : Button
    {
        public bStandart() {
            this.BackColor = System.Drawing.Color.Tomato;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
           // this.Image = global::BarkodluSatis.Properties.Resources.tl_48;
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "BTNNakit";
            this.Size = new System.Drawing.Size(116, 109);
            this.TabIndex = 0;
            this.Text = "NAKİT\r\n(F1)";
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UseVisualStyleBackColor = false;
        }
    }
    class tStandart: TextBox
    {
        public tStandart()
        {
            this.Size = new System.Drawing.Size(250, 26);
            this.BackColor= System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        }
    }
    class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor= System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign= System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += TNumeric_Click;
            this.KeyPress += TNumeric_KeyPress;
        }

        private void TNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar!=(char)08 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void TNumeric_Click(object sender, EventArgs e)
        {
            //İçerisindeki tüm karakterleri seç.
            this.SelectAll();
        }
    }
    class gridOzel: DataGridView
    {
        public gridOzel()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(0, 100);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MultiSelect = false;
            this.Name = "GRIDSatisListesi";
            this.ReadOnly = true;
            this.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.RowHeadersVisible = false;
            this.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.RowsDefaultCellStyle = this.DefaultCellStyle;
            this.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RowTemplate.Height = 32;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(596, 467);
            this.TabIndex = 1;
        }
    }
}
