using DataAccessLayer.Context;
using EntityLayer.Concrete;
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
    public partial class UserMainPage : Form
    {
        public UserMainPage()
        {
            InitializeComponent();

        }

        public static FH_Breakfast fH_Breakfast;
        public static FH_Lunch fH_Lunch;
        public static FH_Dinner fH_Dinner;
        public static FH_Snacks fH_Snack;
        public static FH_ComparingPage fH_ComparingPage;
        public static FH_Badge fH_Badge;
        public static FH_MealSuggestion fH_MealSuggestion;
        public static FH_MyAccount myAccount;
        public static List<Besin> tuketilenTumBesinler = new List<Besin>();
        FatHunterDbContext dbContext = new FatHunterDbContext();

        public static TuketilenUrunler tuketilenUrunler;

        private void UserMainPage_Load(object sender, EventArgs e)
        {
            myAccount = new FH_MyAccount();

            tuketilenUrunler = new TuketilenUrunler()
            {
                KullanıcıID = FH_SignIn.user.KullanıcıID,
                TuketildigiTarih = dtpUserPage.Value,
            };

            dgvAraOgun.DataSource = FH_Snacks.snacksList.ToList();
            dgvKahvalti.DataSource = FH_Breakfast.kahvaltiList.ToList();
            dgvOgleYemegi.DataSource = FH_Lunch.lunchList.ToList();
            dgvAksamYemegi.DataSource = FH_Dinner.dinnerList.ToList();

            //var tuketilenBesinler = FH_Lunch.db.Besinler.Where(x => x.BesininTuketildigiOgun != null && x.TüketilenTarih != null).Select(x => x).ToList();

            //tuketilenTumBesinler = FH_Lunch.db.Besinler.Where(x => x.BesininTuketildigiOgun != null || x.TüketilenTarih != null).Select(x => x).ToList();

            var besins = dbContext.TuketilenUrunlers.Find(FH_SignIn.user.KullanıcıID);

            double yagMiktari = 0;
            double karbMiktari = 0;
            double proMiktari = 0;
            foreach (Besin item in besins.Tuketilenler)
            {
                yagMiktari += item.MakroDeger.YagMiktari;
                karbMiktari += item.MakroDeger.KarbonhidratMiktari;
                proMiktari += item.MakroDeger.ProteinMiktari;
            }
            List<Double> makros = new List<Double>();
            makros.Add(yagMiktari);
            makros.Add(proMiktari);
            makros.Add(karbMiktari);

            dgvGenelDegerler.DataSource = makros.ToList();
        }

        private void btnKahvaltı_Click(object sender, EventArgs e)
        {
            fH_Breakfast = new FH_Breakfast();
            fH_Breakfast.Show();
            this.Hide();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            fH_Lunch = new FH_Lunch();
            fH_Lunch.Show();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            fH_Dinner = new FH_Dinner();
            fH_Dinner.Show();
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            fH_Snack = new FH_Snacks();
            fH_Snack.Show();
        }

        private void btnWaterFollowUp_Click(object sender, EventArgs e)
        {
            tuketilenUrunler.IcilenSu += 1;
        }

        private void UserMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            fH_ComparingPage = new FH_ComparingPage();
            fH_ComparingPage.Show();
            this.Hide();
        }

        private void btnRozetler_Click(object sender, EventArgs e)
        {
            fH_Badge = new FH_Badge();
            fH_Badge.Show();
            this.Hide();
        }

        private void btnÖneriler_Click(object sender, EventArgs e)
        {
            fH_MealSuggestion = new FH_MealSuggestion();
            fH_MealSuggestion.Show();
            this.Hide();
        }

        private void btnHesabım_Click(object sender, EventArgs e)
        {
            myAccount.Show();
            this.Hide();
        }
    }
}
