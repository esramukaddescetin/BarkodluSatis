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
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            TXTAdSoyad.Clear();
            TXTTelefon.Clear();
            TXTEPosta.Clear();
            TXTKullaniciAdi.Clear();
            TXTSifre.Clear();
            CBSatisEkrani.Checked= false;
            CBRapor.Checked= false;
            CBStok.Checked= false;
            CBUrunGiris.Checked= false;
            CBAyarlar.Checked= false;
            CBFiyatGuncelle.Checked= false;
            CBYedekleme.Checked= false;
        }
        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            if (BTNKaydet.Text=="Kaydet")
            {
                if (TXTAdSoyad.Text!=""&& TXTKullaniciAdi.Text!=""&&TXTSifreTekrar.Text!="")
                {
                    if (TXTSifre.Text==TXTSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db= new BarkodDbEntities())
                            {
                                if (!db.Kullanici.Any(x=>x.KullaniciAd==TXTKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad=TXTAdSoyad.Text;
                                    k.Telefon=TXTTelefon.Text;
                                    k.EPosta=TXTEPosta.Text;
                                    k.KullaniciAd=TXTKullaniciAdi.Text.Trim();
                                    k.Sifre = TXTSifre.Text;
                                    k.Satis=CBSatisEkrani.Checked;
                                    k.Rapor=CBRapor.Checked;
                                    k.Stok=CBStok.Checked;
                                    k.UrunGiris=CBUrunGiris.Checked;
                                    k.Ayarlar=CBAyarlar.Checked;
                                    k.FiyatGüncelle=CBFiyatGuncelle.Checked;
                                    k.Yedekleme=CBYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    GRIDListeKullanici.DataSource = db.Kullanici.Select(x => new { x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                                    Temizle();
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Hata Oluştu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor!");
                    }
                }
                else
                {
                    MessageBox.Show("LÜtfen Zorunlu Girişleri Yazınız!"+"\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrar ");
                }
            }
        }
    }
}
