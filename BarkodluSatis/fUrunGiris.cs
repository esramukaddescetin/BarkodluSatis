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
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }
        BarkodDbEntities db= new BarkodDbEntities();
        private void TXTBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barkod = TXTBarkod.Text.Trim();
                if(db.Urun.Any(a => a.Barkod == barkod))
                {
                    var urun = db.Urun.SingleOrDefault(a => a.Barkod == barkod);
                    TXTUrunAdi.Text = urun.UrunAd;
                    TXTAciklama.Text = urun.Aciklama;
                    CBUrunGrubu.Text= urun.UrunGrup;
                    TXTAlisFiyati.Text = urun.AlisFiyat.ToString();
                    TXTSatisFiyati.Text = urun.SatisFiyat.ToString();
                    TXTMiktar.Text= urun.Miktar.ToString();
                    TXTKdvOrani.Text=urun.KdvOrani.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı değil, kaydedebilirsiniz.");
                }
            }
        }

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (TXTBarkod.Text != "" && TXTUrunAdi.Text != "" && CBUrunGrubu.Text != "" && TXTAlisFiyati.Text != "" && TXTSatisFiyati.Text != "" && TXTKdvOrani.Text != "" && TXTMiktar.Text != "")
            {
                //Aynı barkodlu ürün varsa güncelleme yapılır.
                if (db.Urun.Any(a => a.Barkod == TXTBarkod.Text))
                {
                    var guncelle = db.Urun.SingleOrDefault(a => a.Barkod == TXTBarkod.Text);
                    guncelle.UrunAd = TXTUrunAdi.Text;
                    guncelle.Aciklama = TXTAciklama.Text;
                    guncelle.UrunGrup = CBUrunGrubu.Text;
                    guncelle.AlisFiyat = double.Parse(TXTAlisFiyati.Text);
                    guncelle.SatisFiyat = double.Parse(TXTSatisFiyati.Text);
                    guncelle.KdvOrani = int.Parse(TXTKdvOrani.Text);
                    guncelle.KdvTutari = Math.Round(Islemler.DoubleYap(TXTSatisFiyati.Text) * int.Parse(TXTKdvOrani.Text) / 100, 2);
                    //Eklenecek miktar girilmeli.
                    guncelle.Miktar += double.Parse(TXTMiktar.Text);
                    guncelle.Birim = "Adet";
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = LBLKullanici.Text;
                    Temizle();
                    db.SaveChanges();
                    GRIDUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();

                }
                //O barkod kayıtlı değilse yeni ürün eklenir.
                else
                {
                    Urun urun = new Urun();
                    urun.Barkod = TXTBarkod.Text;
                    urun.UrunAd = TXTUrunAdi.Text;
                    urun.Aciklama = TXTAciklama.Text;
                    urun.UrunGrup = CBUrunGrubu.Text;
                    urun.AlisFiyat = double.Parse(TXTAlisFiyati.Text);
                    urun.SatisFiyat = double.Parse(TXTSatisFiyati.Text);
                    urun.KdvOrani = int.Parse(TXTKdvOrani.Text);
                    urun.KdvTutari = Math.Round(Islemler.DoubleYap(TXTSatisFiyati.Text) * int.Parse(TXTKdvOrani.Text) / 100, 2);
                    urun.Miktar = double.Parse(TXTMiktar.Text);
                    urun.Birim = "Adet";
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = LBLKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    Temizle();
                    GRIDUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                }
            }
            else
            {
                MessageBox.Show("Bilgi Girişlerini Kontrol Ediniz!");
                TXTBarkod.Focus();
            }
                

            
        }

        private void TXTUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (TXTUrunAra.Text.Length >= 2)
            {
                string urunad=TXTUrunAra.Text;
                GRIDUrunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
            }
        }
        private void Temizle()
        {
            TXTBarkod.Clear();
            TXTAciklama.Clear();
            TXTUrunAdi.Clear();
            TXTAlisFiyati.Text = "0";
            TXTSatisFiyati.Text = "0";
            TXTMiktar.Text = "0";
            TXTKdvOrani.Text = "8";
            TXTBarkod.Focus();
        }

        private void BTNIptal_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            TXTUrunSayisi.Text = db.Urun.Count().ToString();
            GrupDoldur();
        }
        public void GrupDoldur()
        {
            CBUrunGrubu.DisplayMember = "UrunGrupAd";
            CBUrunGrubu.ValueMember = "Id";
            CBUrunGrubu.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void BTNUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle f= new fUrunGrubuEkle();
            f.ShowDialog();
        }
    }
}
