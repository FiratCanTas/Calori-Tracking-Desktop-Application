using DataAccessLayer.Context;
using EntityLayer.Abstract;
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
        List<Double> makros = new List<Double>();

        public static TuketilenUrunler tuketilenUrun = new TuketilenUrunler();

        private void UserMainPage_Load(object sender, EventArgs e)
        {
            tuketilenUrun.KullanıcıID = FH_SignIn.user.KullanıcıID;
            tuketilenUrun.TuketildigiTarih = dtpUserPage.Value;
            dbContext.TuketilenUrunlers.Add(tuketilenUrun);
            dbContext.SaveChanges();

            dgvAraOgun.DataSource = FH_Snacks.snacksList.ToList();
            dgvKahvalti.DataSource = FH_Breakfast.kahvaltiList.ToList();
            dgvOgleYemegi.DataSource = FH_Lunch.lunchList.ToList();
            dgvAksamYemegi.DataSource = FH_Dinner.dinnerList.ToList();



            double yagMiktari = 0;
            double karbMiktari = 0;
            double proMiktari = 0;

            foreach (Besin item in tuketilenUrun.Tuketilenler)
            {
                yagMiktari += dbContext.MakroDegerler.Find(item.BesinID).YagMiktari;
                karbMiktari += dbContext.MakroDegerler.Find(item.BesinID).KarbonhidratMiktari;
                proMiktari += dbContext.MakroDegerler.Find(item.BesinID).ProteinMiktari;
                tuketilenUrun.TuketilenKalori += item.BesinKalorisi;
            }

            dgvGenelDegerler.ColumnCount = 4;
            dgvGenelDegerler.Columns[0].Name = "Yağ Oranı";
            dgvGenelDegerler.Columns[1].Name = "Karb Oranı";
            dgvGenelDegerler.Columns[2].Name = "Pro Oranı";
            dgvGenelDegerler.Columns[3].Name = "Kalori Miktarı";

            dgvGenelDegerler.Rows.Add(yagMiktari, karbMiktari, proMiktari, tuketilenUrun.TuketilenKalori);

        }

        private void btnKahvaltı_Click(object sender, EventArgs e)
        {
            fH_Breakfast = new FH_Breakfast();
            fH_Breakfast.Show();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            fH_Lunch = new FH_Lunch();
            fH_Lunch.Show();
            this.Hide();
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
            myAccount = new FH_MyAccount();
            myAccount.Show();
            this.Hide();
        }

        private void btnWaterFollowUp_Click_1(object sender, EventArgs e)
        {
            tuketilenUrun.IcilenSu += 1;
        }
    }
}
