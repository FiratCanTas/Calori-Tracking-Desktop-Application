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
    public partial class FH_Dinner : Form
    {
        public FH_Dinner()
        {
            InitializeComponent();
        }
        FatHunterDbContext dbContext;
        Besin besin;
        public static List<Besin> besinlerList = new List<Besin>();
        int tuketilecekBesinID;
        int kaldirilacakBesinID;

        private void FH_Dinner_Load(object sender, EventArgs e)
        {
            besin = new Besin();
            dbContext = new FatHunterDbContext();
            dgvMealList.DataSource = dbContext.Besinler.ToList();
        }

        private void dgvMealList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilecekBesinID = Convert.ToInt32(dgvMealList.CurrentRow.Cells[0].Value);
        }

        private void dgvDinnerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kaldirilacakBesinID = Convert.ToInt32(dgvDinnerList.CurrentRow.Cells[0].Value);
        }

        private void btnAksamOgunuEkle_Click(object sender, EventArgs e)
        {
            var tuketilenBesin = dbContext.Besinler.Find(tuketilecekBesinID);
            tuketilenBesin.TüketilenTarih = DateTime.Today;
            tuketilenBesin.BesininTuketildigiOgun = Ogunler.Aksam;
            besinlerList.Add(tuketilenBesin);
            dgvDinnerList.DataSource = besinlerList.ToList();

            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = besinlerList.ToList();
        }

        private void btnAksamOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = dbContext.Besinler.Find(kaldirilacakBesinID);
            besinlerList.Remove(kaldirilanBesin);

            dgvDinnerList.DataSource = besinlerList.ToList();
            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = besinlerList.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            this.Hide();
            FH_SignIn.userMainPage.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvMealList.DataSource = dbContext.Besinler
                   .Where(x => x.BesinAdı == txtAraDinner.Text)
                   .Select(x => x).ToList();
            if (txtAraDinner.Text == string.Empty)
            {
                dgvMealList.DataSource = dbContext.Besinler.ToList();
            }
        }
    }
}