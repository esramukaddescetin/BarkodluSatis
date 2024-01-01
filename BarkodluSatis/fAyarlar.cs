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
            TXTSifreTekrar.Clear();
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
            if (BTNKaydet.Text == "Kaydet")
            {
                if (TXTAdSoyad.Text != "" && TXTKullaniciAdi.Text != "" && TXTSifreTekrar.Text != "")
                {
                    if (TXTSifre.Text == TXTSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new BarkodDbEntities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == TXTKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = TXTAdSoyad.Text;
                                    k.Telefon = TXTTelefon.Text;
                                    k.EPosta = TXTEPosta.Text;
                                    k.KullaniciAd = TXTKullaniciAdi.Text.Trim();
                                    k.Sifre = TXTSifre.Text;
                                    k.Satis = CBSatisEkrani.Checked;
                                    k.Rapor = CBRapor.Checked;
                                    k.Stok = CBStok.Checked;
                                    k.UrunGiris = CBUrunGiris.Checked;
                                    k.Ayarlar = CBAyarlar.Checked;
                                    k.FiyatGüncelle = CBFiyatGuncelle.Checked;
                                    k.Yedekleme = CBYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    Doldur();
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
                    MessageBox.Show("LÜtfen Zorunlu Girişleri Yazınız!" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrar ");
                }
            }
            else if (BTNKaydet.Text == "Düzenle/Kaydet")
            {
                if (TXTAdSoyad.Text != "" && TXTKullaniciAdi.Text != "" && TXTSifreTekrar.Text != "")
                {
                    if (TXTSifre.Text == TXTSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(LBLKullaniciId.Text);
                        using (var db= new BarkodDbEntities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = TXTAdSoyad.Text;
                            guncelle.Telefon = TXTTelefon.Text;
                            guncelle.EPosta = TXTEPosta.Text;
                            guncelle.KullaniciAd = TXTKullaniciAdi.Text.Trim();
                            guncelle.Sifre = TXTSifre.Text;
                            guncelle.Satis = CBSatisEkrani.Checked;
                            guncelle.Rapor = CBRapor.Checked;
                            guncelle.Stok = CBStok.Checked;
                            guncelle.UrunGiris = CBUrunGiris.Checked;
                            guncelle.Ayarlar = CBAyarlar.Checked;
                            guncelle.Yedekleme = CBYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapıldı!");
                            BTNKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor!");
                    }
                }
                else
                {
                    MessageBox.Show("LÜtfen Zorunlu Girişleri Yazınız!" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrar ");
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRIDListeKullanici.Rows.Count>0)
            {
                int id = Convert.ToInt32(GRIDListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                LBLKullaniciId.Text = id.ToString();
                using (var db=new BarkodDbEntities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    TXTAdSoyad.Text = getir.AdSoyad;
                    TXTTelefon.Text = getir.Telefon;
                    TXTEPosta.Text = getir.EPosta;
                    TXTKullaniciAdi.Text=getir.KullaniciAd;
                    TXTSifre.Text = getir.Sifre;
                    TXTSifreTekrar.Text = getir.Sifre;
                    CBSatisEkrani.Checked = (bool)getir.Satis;
                    CBRapor.Checked = (bool)getir.Rapor;
                    CBStok.Checked = (bool)getir.Stok;
                    CBUrunGiris.Checked = (bool)getir.UrunGiris;
                    CBAyarlar.Checked = (bool)getir.Ayarlar;
                    CBFiyatGuncelle.Checked = (bool)getir.FiyatGüncelle;
                    CBYedekleme.Checked = (bool)getir.Yedekleme;
                    BTNKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı seçiniz!");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            using (var db = new BarkodDbEntities())
            {
                GRIDListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
            }
        }
    }
}
