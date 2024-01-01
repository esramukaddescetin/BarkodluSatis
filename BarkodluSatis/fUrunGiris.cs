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
                    if (TXTBarkod.Text.Length==8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges() ;
                    }
                    Temizle();
                    GRIDUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    Islemler.GridDüzenle(GRIDUrunler);
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
                Islemler.GridDüzenle(GRIDUrunler);
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
            GRIDUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
            Islemler.GridDüzenle(GRIDUrunler);
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

        private void BTNBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8-karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            TXTBarkod.Text = olusanbarkod;
            TXTUrunAdi.Focus();
        }

        private void TXTSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar != (Char)08 && e.KeyChar != (Char)44 && e.KeyChar != (Char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRIDUrunler.Rows.Count>0)
            {
                int urunid = int.Parse(GRIDUrunler.CurrentRow.Cells["UrunId"].Value.ToString());
                string urunad = GRIDUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = GRIDUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(urunad + " ürününü silmek istiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    var urun = db.Urun.Find(urunid);
                    db.Urun.Remove(urun);
                    db.SaveChanges();
                    var hizliurun = db.HizliUrun.SingleOrDefault(a => a.Barkod == barkod);
                    hizliurun.Barkod = "-";
                    hizliurun.UrunAd = "-";
                    hizliurun.fiyat = 0;
                    db.SaveChanges();
                    MessageBox.Show("Ürün Silinmiştir!");
                    GRIDUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    Islemler.GridDüzenle(GRIDUrunler);
                    TXTBarkod.Focus();
                }
            }
            
        }
    }
}
