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
    public partial class fHizliButonUrunEkle : Form
    {
        BarkodDbEntities db = new BarkodDbEntities();

        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }
        private void TXTUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (TXTUrunAra.Text != "")
            {
                string urunad = TXTUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                GRIDUrunler.DataSource = urunler;
            }
        }

        private void GRIDUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GRIDUrunler.Rows.Count > 0)
            {
                string barkod = (GRIDUrunler.CurrentRow.Cells["Barkod"].Value).ToString();
                string urunad = (GRIDUrunler.CurrentRow.Cells["UrunAd"].Value).ToString();
                double fiyat = double.Parse((GRIDUrunler.CurrentRow.Cells["SatisFiyat"].Value).ToString());
                int id = int.Parse(LBLButonId.Text);
                // Id'ye sahip satırı güncellenecek değişkenine attı.
                var güncellenecek = db.HizliUrun.Find(id);
                güncellenecek.Barkod = barkod;
                güncellenecek.UrunAd = urunad;
                güncellenecek.fiyat = fiyat;
                db.SaveChanges();
                //Yeni formdan önceki açılmış forma dönme.
                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                Button b = f.Controls.Find("bH" + id, true).FirstOrDefault() as Button;
                b.Text = urunad + "\n" + fiyat.ToString("C2");
            }
        }

        private void CBTumu_CheckedChanged(object sender, EventArgs e)
        {
            if(CBTumu.Checked)
            {
                GRIDUrunler.DataSource = db.Urun.ToList();
            }
            else
            {
                GRIDUrunler.DataSource=null;
            }

        }
    }
}
