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
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void BTNSatisIslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current= Cursors.WaitCursor;
            fSatis f= new fSatis();
            f.LBLKullanici.Text = LBLKullanici.Text;
            f.ShowDialog();
            Cursor.Current=Cursors.Default;
        }

        private void BTNGenelRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //video30 dk 17
            Cursor.Current = Cursors.Default;
        }

        private void BTNStok_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fStok f = new fStok();
            f.LBLKullanici.Text = LBLKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BTNUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fUrunGiris f = new fUrunGiris();
            f.LBLKullanici.Text = LBLKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

    private void BTNAyarlar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fAyarlar f = new fAyarlar();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BTNCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
