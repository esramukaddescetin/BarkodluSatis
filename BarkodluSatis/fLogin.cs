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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void BTNGiris_Click(object sender, EventArgs e)
        {
            if (TXTKullaniciAdi.Text!=""&& TXTSifre.Text!="")
            {
                try
                {
                    using (var db= new BarkodDbEntities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == TXTKullaniciAdi.Text && x.Sifre == TXTSifre.Text).FirstOrDefault();
                            if (bak!=null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                fBaslangic f = new fBaslangic();
                                f.BTNSatisIslemi.Enabled = (bool)bak.Satis;
                                f.BTNGenelRapor.Enabled = (bool)bak.Rapor;
                                f.BTNStok.Enabled = (bool)bak.Stok;
                                f.BTNUrunGiris.Enabled = (bool)bak.UrunGiris;
                                f.BTNAyarlar.Enabled = (bool)bak.Ayarlar;
                                f.BTNFiyatGuncelle.Enabled = (bool)bak.FiyatGüncelle;
                                f.BTNYedekleme.Enabled = (bool)bak.Yedekleme;
                                f.LBLKullanici.Text = bak.AdSoyad;
                                //var isyeri = db.Sabit.FirstorDefault(); video39devam.dk20
                                f.Show();
                                this.Hide();
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
            }
        }
    }
}
