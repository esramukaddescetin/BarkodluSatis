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
                                //fBaslangic f=new fBaslangic();
                                //39. video dk. 14 tekrar bak yap!!
                                //f.bSatisIslemi.Enable=(bool)bak.Satis;
                                //f.bGenelRapor.Enable=(bool)bak.Rapor;
                                //f.bStok.Enable=(bool)bak.Stok;
                                //f.bUrunGiris.Enable=(bool)bak.UrunGiris;
                                //f.bAyarlar.Enable=(bool)bak.Ayarlar;
                                //f.bFiyatGuncelle.Enable=(bool)bak.FiyatGuncelle;
                                //f.bYedekleme.Enable=(bool)bak.Yedekleme;
                                Cursor.Current = Cursors.Default;
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
