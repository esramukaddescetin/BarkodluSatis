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
            b5.Text=5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
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
                UrunGetirListeye(urun, urunbarkod, double.Parse(TXTMiktar.Text));
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
                row.Cells["UrunAdi"].Value = urun.UrunAd;
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
            TXTMiktar.Text = "1";
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

        private void bh_MouseDown(object sender, MouseEventArgs e) { 
            if(e.Button == MouseButtons.Right) {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int butonid = int.Parse(b.Name.ToString().Substring(2, b.Name.Length-2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil= new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No: " + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add( sil );
                    this.ContextMenuStrip = s;

                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = int.Parse(sender.ToString().Substring(20, sender.ToString().Length-20));
            var guncelle = db.HizliUrun.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bH" + butonid, true).FirstOrDefault() as Button;
            b.Text="-"+"/n"+fiyat.ToString("C2");
        }

        //Numaratör Butonları İle Girişi
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b= (Button)sender;
            if (b.Text == ",")
            {
                int virgul = TXTNumarator.Text.Count(x=>x==',');
                if (virgul < 1)
                {
                    TXTNumarator.Text += b.Text;
                }
            }
            else if(b.Text=="<"){
                if (TXTNumarator.Text.Length > 0)
                {
                    TXTNumarator.Text= TXTNumarator.Text.Substring(0,TXTNumarator.Text.Length-1);
                }
            }
            else
            {
                TXTNumarator.Text += b.Text;
            }
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (TXTNumarator.Text != "")
            {
                TXTMiktar.Text = TXTNumarator.Text;
                TXTNumarator.Clear();
                TXTBarkod.Clear();
                TXTBarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (TXTNumarator.Text != "")
            {
                double sonuc = Islemler.DoubleYap(TXTNumarator.Text) - Islemler.DoubleYap(TXTGenelToplam.Text);
                TXTParaUstu.Text = sonuc.ToString("C2");
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {

        }

        private void ParaUstuHesapla_Click(object sender, EventArgs e) {
            Button b = (Button)sender;
            double sonuc = Islemler.DoubleYap(b.Text) - Islemler.DoubleYap(TXTGenelToplam.Text);
            TXTParaUstu.Text = sonuc.ToString("C2");
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (TXTNumarator.Text != "")
            {
                int satirsayisi = GRIDSatisListesi.Rows.Count;
                GRIDSatisListesi.Rows.Add();
                GRIDSatisListesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                GRIDSatisListesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                GRIDSatisListesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                GRIDSatisListesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                GRIDSatisListesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                GRIDSatisListesi.Rows[satirsayisi].Cells["Fiyat"].Value = double.Parse(TXTNumarator.Text);
                GRIDSatisListesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                GRIDSatisListesi.Rows[satirsayisi].Cells["Toplam"].Value = double.Parse(TXTNumarator.Text);
                GenelToplam();
                TXTNumarator.Text = "";
                TXTBarkod.Focus();
            }
        }

        private void BTNIade_Click(object sender, EventArgs e)
        {
            if(CBSatisIadeIslemi.Checked)// seçiliyse gir   
            {
                CBSatisIadeIslemi.Checked = false;
                CBSatisIadeIslemi.Text = "Satış Yapılıyor";
            }
            else
            {
                CBSatisIadeIslemi.Checked = true;
                CBSatisIadeIslemi.Text = "İade İşlemi";
            }
        }

        private void BTNTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void Temizle()
        {
            TXTMiktar.Text = "1";
            TXTBarkod.Clear();
            TXTOdenen.Clear();
            TXTParaUstu.Clear();
            TXTGenelToplam.Text=0.ToString("C2");
            CBSatisIadeIslemi.Checked=false;
            TXTNumarator.Clear();
            GRIDSatisListesi.Rows.Clear();
            TXTBarkod.Focus();
        }
    }
}
