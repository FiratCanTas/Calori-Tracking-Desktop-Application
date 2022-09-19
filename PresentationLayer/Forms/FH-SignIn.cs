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
    public partial class FH_SignIn : Form
    {
        public FH_SignIn()
        {
            fH_ChangePassword = new FH_ChangePassword();
            fH_ContactUs = new FH_ContactUs();
            userMainPage = new UserMainPage();
            InitializeComponent();
        }

        public static FH_ChangePassword fH_ChangePassword;
        public static UserMainPage userMainPage;
        public static FH_ContactUs fH_ContactUs;

        private void FH_SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            fH_ChangePassword.Show();
            this.Hide();
        }

        private void FH_SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            userMainPage.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            fH_ContactUs.Show();
            this.Hide();
        }
    }
}
