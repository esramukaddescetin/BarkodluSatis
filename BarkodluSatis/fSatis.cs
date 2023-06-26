using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Superpower;

namespace BarkodluSatis
{
    public partial class fSatis : Form
    {
        BarkodDbEntities db = new BarkodDbEntities();

        public fSatis()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TXTBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            string barkod = TXTBarkod.Text.Trim();
            if (barkod.Length <= 2)
            {
                TXTMiktar.Text = barkod;
                TXTBarkod.Clear();
                TXTBarkod.Focus();
            }
            else
            {
                if (db.Urun.Any(a => a.Barkod == barkod))
                {
                    // EĞER MİKTAR ALANINI SAYIYA DÖNÜŞTÜREMEZSE. BURAYA GİR.
                    if (!double.TryParse(TXTMiktar.Text, out double miktar))
                    {
                        MessageBox.Show("Lütfen Adet giriniz");
                        TXTMiktar.Focus();
                        return;
                    }

                    var urun = db.Urun.FirstOrDefault(a => a.Barkod == barkod);

                    int satirsayisi = GRIDSatisListesi.Rows.Count;
                    bool eklenmismi = false;

                    if (satirsayisi > 0)
                    {
                        for (int i = 0; i < satirsayisi; i++)
                        {
                            var currentROw = GRIDSatisListesi.Rows[i];
                            if (currentROw.Cells["Barkod"].Value.ToString() == barkod)
                            {

                                miktar += Convert.ToDouble(currentROw.Cells["Miktar"].Value);
                                double varOlanFiyat = Convert.ToDouble(currentROw.Cells["Fiyat"].Value);


                                currentROw.Cells["Miktar"].Value = miktar;
                                currentROw.Cells["Toplam"].Value = Math.Round(miktar * varOlanFiyat, 2);

                                eklenmismi = true;
                            }
                        }
                    }

                    if (!eklenmismi)
                    {
                        GRIDSatisListesi.Rows.Add();
                        var row = GRIDSatisListesi.Rows[satirsayisi];
                        row.Cells["Barkod"].Value = barkod;
                        row.Cells["UrünAdi"].Value = urun.UrunAd;
                        row.Cells["UrunGrup"].Value = urun.UrunGrup;
                        row.Cells["Birim"].Value = urun.Birim;
                        row.Cells["Fiyat"].Value = urun.SatisFiyat;
                        row.Cells["Miktar"].Value = miktar;
                        row.Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                        row.Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        row.Cells["KdvTutari"].Value = urun.KdvTutari;
                    }
                }
            }

            GRIDSatisListesi.ClearSelection();
            GenelToplam();

        }

        private void GenelToplam()
        {
            if (GRIDSatisListesi.Rows.Count > 0)
            {
                double toplam = 0;
                for (int i = 0; i < GRIDSatisListesi.Rows.Count; i++)
                {
                    toplam += Convert.ToDouble(GRIDSatisListesi.Rows[i].Cells["Toplam"].Value);
                }
                TXTGenelToplam.Text = toplam.ToString("C2");
                TXTBarkod.Clear();
                TXTBarkod.Focus();
            }
        }
    }
}
