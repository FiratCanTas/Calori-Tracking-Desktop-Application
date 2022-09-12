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
    }
}
