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
            if (txtAraLunch.Text != string.Empty)
            {
                dgvLuchList.DataSource = db.Besinler
                    .Where(x => x.BesinAdı == txtAraLunch.Text)
                    .Select(x => x).ToList();
            }
            else
            {
                dgvLuchList.DataSource = db.Besinler.ToList();
            }
        }

        public static FatHunterDbContext db = new FatHunterDbContext();
        Besin besin = new Besin();
        UserMainPage userMainPage = new UserMainPage();
        public static List<Besin> besinlerList = new List<Besin>();
        public int tuketilenBesinClickId;
        public int secilenYemekClickId;
        private void btnOgleOgunuEkle_Click(object sender, EventArgs e)
        {
            var tuketilenBesin = db.Besinler.Find(tuketilenBesinClickId);
            if (tuketilenBesin != null)
            {
                tuketilenBesin.TüketilenTarih = DateTime.Today;
                tuketilenBesin.BesininTuketildigiOgun = Ogunler.Ogle;
                besinlerList.Add(tuketilenBesin);
                dgvSecilenYemekler.DataSource = besinlerList.ToList();

                userMainPage.dgvOgleYemegi.DataSource = besinlerList.ToList();
            }
            else
            {
                MessageBox.Show("Ürün seçimi yapılamadı! Lütfen tekrar deneyiniz.");
            }
           

        }

        private void btnOgleOgunuKaldir_Click(object sender, EventArgs e)
        {
            var kaldirilanBesin = db.Besinler.Find(secilenYemekClickId);
            besinlerList.Remove(kaldirilanBesin);

            dgvSecilenYemekler.DataSource = besinlerList.ToList();
            userMainPage.dgvOgleYemegi.DataSource = besinlerList.ToList();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            this.Hide();
            userMainPage.Show();

        }

        private void FH_Lunch_Load(object sender, EventArgs e)
        {
            besin = new Besin();
            db = new FatHunterDbContext();
            dgvLuchList.DataSource = db.Besinler.ToList();
        }


      
        private void dgvLuchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tuketilenBesinClickId = Convert.ToInt32(dgvLuchList.Rows[e.RowIndex].Cells[0].Value);

        }

        private void dgvSecilenYemekler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenYemekClickId = Convert.ToInt32(dgvSecilenYemekler.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
