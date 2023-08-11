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
            if (TXTBarkod.Text!="" && TXTUrunAdi.Text!="" && CBUrunGrubu.Text!="" && TXTAlisFiyati.Text!="" && TXTSatisFiyati.Text!="" && TXTKdvOrani.Text!="" && TXTMiktar.Text!="")
            {
                Urun urun = new Urun();
                urun.Barkod= TXTBarkod.Text;
                urun.UrunAd= TXTUrunAdi.Text;
                urun.Aciklama= TXTAciklama.Text;
                urun.UrunGrup= CBUrunGrubu.Text;
                urun.AlisFiyat = double.Parse(TXTAlisFiyati.Text);
                urun.SatisFiyat = double.Parse(TXTSatisFiyati.Text);
                urun.KdvOrani=int.Parse(TXTKdvOrani.Text);
                urun.KdvTutari = Math.Round(Islemler.DoubleYap(TXTSatisFiyati.Text) * int.Parse(TXTKdvOrani.Text)/100 , 2 );
                urun.Miktar= double.Parse(TXTMiktar.Text);
                urun.Birim = "Adet";
                urun.Tarih=DateTime.Now;
                urun.Kullanici = LBLKullanici.Text;
                db.Urun.Add(urun);
                db.SaveChanges();
                TXTBarkod.Clear();
                TXTAciklama.Clear();
                TXTUrunAdi.Clear();
                TXTAlisFiyati.Text="0";
                TXTSatisFiyati.Text ="0";
                TXTMiktar.Text ="0";
                TXTKdvOrani.Text="8";
                GRIDUrunler.DataSource=db.Urun.OrderByDescending(a=>a.UrunId).Take(10).ToList();

            }
        }
    }
}
