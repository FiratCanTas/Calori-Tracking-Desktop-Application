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
    public partial class FH_Snacks : Form
    {
        public FH_Snacks()
        {
            InitializeComponent();
        }

        FatHunterDbContext dbContext;
        public static List<Besin> araOgunListe = new List<Besin>();
        int tuketilecekBesinID;
        int kaldirilacakBesinID;

        private void FH_Snacks_Load(object sender, EventArgs e)
        {
            dbContext = new FatHunterDbContext();
            dgvMealList.DataSource = dbContext.Besinler.ToList();
        }

        private void dgvMealList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilecekBesinID = Convert.ToInt32(dgvMealList.CurrentRow.Cells[0].Value);
        }

        private void dgvSnackList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kaldirilacakBesinID = Convert.ToInt32(dgvSnackList.CurrentRow.Cells[0].Value);
        }

        private void btnAraOgunEkle_Click(object sender, EventArgs e)
        {
            var tuketilenBesin = dbContext.Besinler.Find(tuketilecekBesinID);
            tuketilenBesin.TüketilenTarih = DateTime.Today;
            tuketilenBesin.BesininTuketildigiOgun = Ogunler.Aksam;
            araOgunListe.Add(tuketilenBesin);
            dgvSnackList.DataSource = araOgunListe.ToList();

            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = araOgunListe.ToList();
        }

        private void btnAraOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = dbContext.Besinler.Find(kaldirilacakBesinID);
            araOgunListe.Remove(kaldirilanBesin);

            dgvSnackList.DataSource = araOgunListe.ToList();
            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = araOgunListe.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            this.Hide();
            FH_SignIn.userMainPage.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAraSnacks.Text != string.Empty)
            {
                dgvMealList.DataSource = dbContext.Besinler
                    .Where(x => x.BesinAdı == txtAraSnacks.Text)
                    .Select(x => x).ToList();
            }
            else
            {
                dgvMealList.DataSource = dbContext.Besinler.ToList();
            }
        }
    }
}
