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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }
        BarkodDbEntities db= new BarkodDbEntities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void BTNEkle_Click(object sender, EventArgs e)
        {
            if (TXTUrunGrupAd.Text!="")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd= TXTUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                TXTUrunGrupAd.Clear();
                TXTUrunGrupAd.Focus();
                MessageBox.Show("Ürün Grubu Eklenmiştir!");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)
                    f.GrupDoldur();
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz!");
            }
        }
        private void GrupDoldur()
        {
            LBUrunGrup.DisplayMember = "UrunGrupAd";
            LBUrunGrup.ValueMember = "Id";
            LBUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }
    }
}
