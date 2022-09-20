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


        }

        private void btnOgleOgunuKaldir_Click(object sender, EventArgs e)
        {

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {

        }

        private void FH_Lunch_Load(object sender, EventArgs e)
        {

        }
        public int tuketilenBesinClickId;
        public int secilenYemekClickId;
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
