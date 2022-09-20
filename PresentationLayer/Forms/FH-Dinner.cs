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

        //TuketilenBesin tuketilenBesin;
        FatHunterDbContext dbContext;
        Besin besin;
        public static List<Besin> besinlerList = new List<Besin>();
        int tuketilecekBesinID;

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

        private void btnAksamOgunuEkle_Click(object sender, EventArgs e)
        {
            //tuketilenBesin = new TuketilenBesin()
            //{
            //    TüketilenTarih = DateTime.Today,
            //    BesininTuketildigiOgun = Ogunler.Aksam
            //};

            //tuketilenBesin.BesinID = tuketilecekBesinID;

            //besin.TuketilenBesinID = tuketilenBesin.TuketilenBesinID;
            //dbContext.TuketilenBesinler.Add(tuketilenBesin);
            //dbContext.SaveChanges();

            //dgvDinnerList.DataSource = dbContext.Besinler.Where(x => x.TuketilenBesinID != 0).Select(x=> x).ToList();

            var tuketilenBesin = dbContext.Besinler.Find(tuketilecekBesinID);
            tuketilenBesin.TüketilenTarih = DateTime.Today;
            tuketilenBesin.BesininTuketildigiOgun = Ogunler.Aksam;
            besinlerList.Add(tuketilenBesin);
            dbContext.SaveChanges();

            //dgvDinnerList.DataSource = dbContext.Besinler.Where(x => x.BesininTuketildigiOgun == Ogunler.Aksam && x.TüketilenTarih == DateTime.Today).Select(x => x).ToList();
            dgvDinnerList.DataSource = besinlerList.ToList();

            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = besinlerList.ToList();


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