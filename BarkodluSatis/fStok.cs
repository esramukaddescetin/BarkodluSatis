using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void BTNAra_Click(object sender, EventArgs e)
        {
            GRIDListe.DataSource = null;
            using (var db=new BarkodDbEntities())
            {
                string urungrubu = CBUrunGrubu.Text;
                if (CBIslemTuru.Text == "")
                    return;
                if (CBIslemTuru.SelectedIndex != 0)
                    return;
                if (RBTumu.Checked){
                    db.Urun.OrderBy(x => x.Miktar).Load();
                    GRIDListe.DataSource = db.Urun.Local.ToBindingList();}
                else if(RBUrunGrubunaGore.Checked){
                    db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                    GRIDListe.DataSource = db.Urun.Local.ToBindingList();}
                if (CBIslemTuru.SelectedIndex==1)
                {
                    DateTime baslangic = DateTime.Parse(DATEBaslangic.Value.ToShortDateString());
                    DateTime bitis = DateTime.Parse(DATEBitis.Value.ToShortDateString());
                    if (RBTumu.Checked)
                    {

                    }
                }
            }
        }
        BarkodDbEntities dbx= new BarkodDbEntities();
        private void fStok_Load(object sender, EventArgs e)
        {
            CBUrunGrubu.DisplayMember = "UrunGrupAd";
            CBUrunGrubu.ValueMember= "Id";
            CBUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }
    }
}
