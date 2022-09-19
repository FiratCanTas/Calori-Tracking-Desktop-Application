using DataAccessLayer.Context;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class FH_Lunch : Form
    {
        public FH_Lunch()
        {
            InitializeComponent();
        }



        private void txtAraLunch_TextChanged(object sender, EventArgs e)
        {
                       
                                
        }

       
        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvLuchList.DataSource = db.Besinler
                               .Where(x => x.BesinAdı == txtAraLunch.Text)
                               .Select(x => x).ToList();
        }

        FatHunterDbContext db = new FatHunterDbContext();
        TuketilenBesin tuketilenBesin = new TuketilenBesin();
        Besin besin = new Besin();
        UserMainPage userMainPage = new UserMainPage();
        private void btnOgleOgunuEkle_Click(object sender, EventArgs e)
        {

           tuketilenBesin.BesinId = tuketilenBesinClickId;
            var eklemeYapilacakBesin = db.Besinler.Find(tuketilenBesin.BesinId);
            eklemeYapilacakBesin.TuketilenBesinId = tuketilenBesin.TuketilenBesinID;
            
            tuketilenBesin.BesininTuketildigiOgun = Ogunler.Ogle;
            tuketilenBesin.TüketilenTarih = DateTime.Today;
            db.TuketilenBesinler.Add(tuketilenBesin);
            db.SaveChanges();

           
            var tuketilenTablosundakiBesinId = db.TuketilenBesinler.Where(x => x.BesininTuketildigiOgun == Ogunler.Ogle && x.TüketilenTarih == DateTime.Today && x.BesinId != 0).Select(x => x.TuketilenBesinID).FirstOrDefault();

            var besiniTablosundanBul = db.Besinler.Find(tuketilenTablosundakiBesinId);
            
            dgvSecilenYemekler.DataSource = db.Besinler.Where(x => x.TuketilenBesinId == tuketilenTablosundakiBesinId).Select(x=> x).ToList();
          
        }

        private void btnOgleOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilacakOgunId = secilenYemekClickId;

            var kaldirilacakYemek = db.TuketilenBesinler.Find(kaldirilacakOgunId);

            db.TuketilenBesinler.Remove(kaldirilacakYemek);

            db.SaveChanges();

            var tuketimZamani = tuketilenBesin.BesininTuketildigiOgun;

            var besinId = db.Besinler.Where(x => tuketimZamani == Ogunler.Ogle).Select(x => x.BesinID).FirstOrDefault();

            dgvSecilenYemekler.DataSource = db.Besinler.Where(x => x.BesinID == besinId).Select(x => x).ToList();



        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            var tuketimZamani = tuketilenBesin.BesininTuketildigiOgun;
            var besinId = db.Besinler.Where(x => tuketimZamani == Ogunler.Ogle).Select(x => x.BesinID).FirstOrDefault();
            
            userMainPage.dgvOgleYemegi.DataSource = db.Besinler.Where(x => x.BesinID == besinId).Select(x => x).ToList();

            userMainPage.Show();
            this.Hide();
        }

        private void FH_Lunch_Load(object sender, EventArgs e)
        {
            dgvLuchList.DataSource = db.Besinler.ToList();
        }
       public int tuketilenBesinClickId;
        public int secilenYemekClickId;
        private void dgvLuchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilenBesinClickId = Convert.ToInt32( dgvLuchList.Rows[e.RowIndex].Cells[0].Value);
           
        }

        private void dgvSecilenYemekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenYemekClickId = Convert.ToInt32(dgvSecilenYemekler.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
