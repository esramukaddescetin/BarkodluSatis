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
    public partial class fSatis : Form
    {
        private void fSatis_Load(object sender, EventArgs e)
        {
            HizliButonDoldur();
        }
        private void HizliButonDoldur()
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach (var item in hizliurun)
            {
                //true= tüm alt kontrolleri aramak için, aksi taktirde = false.
                Button bH = this.Controls.Find("bH" + item.Id, true).FirstOrDefault() as Button;
                if (bH != null)
                {
                    double fiyat = Islemler.DoubleYap((item.fiyat).ToString());
                    bH.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }
        private void HizliButtonClick(object sender, EventArgs e)
        {
            //Gelen nessneyi buton olarak aç. b' ye aktar.
            Button b = (Button)sender;
            //örn name: bH21
            int butonid = int.Parse(b.Name.ToString().Substring(2, b.Name.Length - 2));
            if (b.Text.ToString().StartsWith("-"))
            {
                fHizliButonUrunEkle f = new fHizliButonUrunEkle();
                f.LBLButonId.Text = butonid.ToString();
                f.ShowDialog();
            }
            else
            {

                var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListeye(urun, urunbarkod, 1);
                GenelToplam();
            }
        }

        BarkodDbEntities db = new BarkodDbEntities();

        public fSatis()
        {
            InitializeComponent();
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
                    // ÜRÜN BARKOD ÜZERİNDEN LİSTEYE EKLENECEKSE.
                    var urun = db.Urun.FirstOrDefault(a => a.Barkod == barkod);
                    UrunGetirListeye(urun, barkod, double.Parse(TXTMiktar.Text));

                }
                //ÜRÜN KG CİNSİNDEN HESAPLANACAK İSE BARKODUN BAŞINDAKİ SAYI KONTROL EDİLEREK LİSTEYE EKLEME.
                else
                {
                    int onek = int.Parse(barkod.Substring(0, 2));
                    // BARKODUN 2-7 ARASINDAKİ ÜRÜN KODU DEĞERİ EŞLEŞTİRİLİR.
                    if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                    {
                        string teraziurunno = barkod.Substring(2, 5);
                        // 7-12 ARASI ÜRÜN KG HESAPLAMA.
                        if (db.Urun.Any(a => a.Barkod == teraziurunno))
                        {
                            var urunterazi = db.Urun.FirstOrDefault(a => a.Barkod == teraziurunno);
                            double miktarkg = double.Parse(barkod.Substring(7, 5)) / 1000;
                            UrunGetirListeye(urunterazi, teraziurunno, miktarkg);
                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            MessageBox.Show("Kg Ürün Ekleme Sayfası");
                        }
                    }
                    else
                    {
                        Console.Beep(900, 2000);
                        MessageBox.Show("Normal Ürün Ekleme Sayfası");
                    }
                }
            }

            GRIDSatisListesi.ClearSelection();
            GenelToplam();

        }

        private void UrunGetirListeye(Urun urun, string barkod, double miktar)
        {
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

        private void GenelToplam()
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


        private void GRIDSatisListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                GRIDSatisListesi.Rows.Remove(GRIDSatisListesi.CurrentRow);
                GRIDSatisListesi.ClearSelection();
                GenelToplam();
                TXTBarkod.Focus();
            }
        }


    }
}
