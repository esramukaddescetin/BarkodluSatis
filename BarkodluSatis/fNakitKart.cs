using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fNakitKart : Form
    {
        public fNakitKart()
        {
            InitializeComponent();
        }

        private void fNakitKart_Load(object sender, EventArgs e)
        {

        }

        private void TXTNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (TXTNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Hesapla();
                }
            }
        }
        private void Hesapla()
        {
            //Mevcut açılmış forma dönmek için.
            fSatis f = (fSatis)Application.OpenForms["fSatis"];
            double nakit = Islemler.DoubleYap(TXTNakit.Text);
            double geneltoplam = Islemler.DoubleYap(f.TXTGenelToplam.Text);
            double kart = geneltoplam - nakit;
            f.LBLNakit.Text = nakit.ToString("C2");
            f.LBLKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }

        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = TXTNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    TXTNakit.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (TXTNakit.Text.Length > 0)
                {
                    TXTNakit.Text = TXTNakit.Text.Substring(0, TXTNakit.Text.Length - 1);
                }
            }
            else
            {
                TXTNakit.Text += b.Text;
            }
        }

        private void BTNEnter_Click(object sender, EventArgs e)
        {
            if (TXTNakit.Text != "")
                Hesapla();
        }

        private void TXTNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TextBox'ın klavyeden girilen sadece rakam ve geri tuşunu algılaması için.
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar!=(char)08)
                e.Handled= true;
        }
    }
}
