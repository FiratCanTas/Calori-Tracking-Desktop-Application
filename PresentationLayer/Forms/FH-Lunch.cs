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

        FatHunterDbContext dbContext;
        public static List<Besin> lunchList = new List<Besin>();
        int tuketilecekBesinID;
        int kaldirilacakBesinID;


        private void FH_Lunch_Load(object sender, EventArgs e)
        {
            dbContext = new FatHunterDbContext();
            dgvMealList.DataSource = dbContext.Besinler.ToList();
        }

        private void dgvLuchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilecekBesinID = Convert.ToInt32(dgvMealList.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dgvSecilenYemekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kaldirilacakBesinID = Convert.ToInt32(dgvLunchList.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnOgleOgunuEkle_Click(object sender, EventArgs e)
        {
            var tuketilenBesin = dbContext.Besinler.Find(tuketilecekBesinID);

            if (tuketilenBesin != null)
            {
                tuketilenBesin.TüketilenTarih = DateTime.Today;
                tuketilenBesin.BesininTuketildigiOgun = Ogunler.Ogle;
                lunchList.Add(tuketilenBesin);
                dgvLunchList.DataSource = lunchList.ToList();
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapılamadı! Lütfen tekrar deneyiniz.");
            }
        }

        private void btnOgleOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = dbContext.Besinler.Find(kaldirilacakBesinID);
            lunchList.Remove(kaldirilanBesin);

            dgvMealList.DataSource = lunchList.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            foreach (var item in lunchList)
            {
                UserMainPage.tuketilenUrun.Tuketilenler.Add(item);
            }

            FH_SignIn.userMainPage.dgvOgleYemegi.DataSource = lunchList.ToList();

            this.Hide();
            FH_SignIn.userMainPage.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAraLunch.Text != string.Empty)
            {
                dgvMealList.DataSource = dbContext.Besinler
                    .Where(x => x.BesinAdı == txtAraLunch.Text)
                    .Select(x => x).ToList();
            }
            else
            {
                dgvMealList.DataSource = dbContext.Besinler.ToList();
            }
        }
    }
}
