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
    public partial class FH_Breakfast : Form
    {
        public FH_Breakfast()
        {
            InitializeComponent();
        }

        FatHunterDbContext dbContext;
        public static List<Besin> kahvaltiList = new List<Besin>();
        int tuketilecekBesinID;
        int kaldirilacakBesinID;

        private void FH_Breakfast_Load(object sender, EventArgs e)
        {
            dbContext = new FatHunterDbContext();
            dgvMealList.DataSource = dbContext.Besinler.ToList();
        }

        private void dgvMealList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilecekBesinID = Convert.ToInt32(dgvMealList.CurrentRow.Cells[0].Value);
        }

        private void dgvBreakfastList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kaldirilacakBesinID = Convert.ToInt32(dgvBreakfastList.CurrentRow.Cells[0].Value);
        }

        private void btnKahvaltiEkle_Click(object sender, EventArgs e)
        {
            var tuketilenBesin = dbContext.Besinler.Find(tuketilecekBesinID);
            if (tuketilenBesin != null)
            {
                tuketilenBesin.TüketilenTarih = DateTime.Today;
                tuketilenBesin.BesininTuketildigiOgun = Ogunler.Aksam;
                kahvaltiList.Add(tuketilenBesin);
                dgvBreakfastList.DataSource = kahvaltiList.ToList();

                FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = kahvaltiList.ToList();
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapılamadı! Lütfen tekrar deneyiniz.");
            }

        }

        private void btnKahvaltiOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = dbContext.Besinler.Find(kaldirilacakBesinID);
            kahvaltiList.Remove(kaldirilanBesin);

            dgvBreakfastList.DataSource = kahvaltiList.ToList();
            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = kahvaltiList.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            this.Hide();
            FH_SignIn.userMainPage.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAraBreakfast.Text == string.Empty)
            {
                dgvMealList.DataSource = dbContext.Besinler
                            .Where(x => x.BesinAdı == txtAraBreakfast.Text)
                            .Select(x => x).ToList();
            }
            else
            {
                dgvMealList.DataSource = dbContext.Besinler.ToList();
            }
        }
    }
}
