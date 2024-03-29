﻿using DataAccessLayer.Context;
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
        public static List<Besin> dinnerList = new List<Besin>();
        int tuketilecekBesinID;
        int kaldirilacakBesinID;

        private void FH_Dinner_Load(object sender, EventArgs e)
        {
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

            if (tuketilenBesin != null)
            {
                tuketilenBesin.TüketilenTarih = DateTime.Today;
                tuketilenBesin.BesininTuketildigiOgun = Ogunler.Aksam;
                dinnerList.Add(tuketilenBesin);
                dgvDinnerList.DataSource = dinnerList.ToList();
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapılamadı! Lütfen tekrar deneyiniz.");
            }
        }

        private void btnAksamOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = dbContext.Besinler.Find(kaldirilacakBesinID);
            dinnerList.Remove(kaldirilanBesin);

            dgvDinnerList.DataSource = dinnerList.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            foreach (var item in dinnerList)
            {
                UserMainPage.tuketilenUrun.Tuketilenler.Add(item);
            }

            FH_SignIn.userMainPage.dgvAksamYemegi.DataSource = dinnerList.ToList();
            this.Hide();
            FH_SignIn.userMainPage.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAraDinner.Text == string.Empty)
            {
                dgvMealList.DataSource = dbContext.Besinler
                            .Where(x => x.BesinAdı == txtAraDinner.Text)
                            .Select(x => x).ToList();
            }
            else
            {
                dgvMealList.DataSource = dbContext.Besinler.ToList();
            }
        }
    }
}