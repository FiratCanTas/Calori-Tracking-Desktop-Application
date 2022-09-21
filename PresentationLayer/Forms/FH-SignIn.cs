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
    public partial class FH_SignIn : Form
    {
        public FH_SignIn()
        {
            InitializeComponent();
        }

        FatHunterDbContext dbContext;
        public static FH_ChangePassword fH_ChangePassword;
        public static UserMainPage userMainPage;
        public static FH_ContactUs fH_ContactUs;
        bool gizliMi;

        private void FH_SignIn_Load(object sender, EventArgs e)
        {
            fH_ChangePassword = new FH_ChangePassword();
            fH_ContactUs = new FH_ContactUs();
            userMainPage = new UserMainPage();
            dbContext = new FatHunterDbContext();
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
            //foreach (Kullanici kullanici in dbContext.Kullanıcılar)
            //{
            //    if (kullanici.KullanıcıMail == txtEmailAdresiniz.Text && kullanici.KullanıcıŞifre == txtSifreniz.Text)
            //    {
            //        userMainPage.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("E-Mail adresi ya da şifre hatalı!");
            //    }
            //}
            userMainPage.Show();
            this.Hide();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            fH_ContactUs.Show();
            this.Hide();
        }

        private void btnSifreGizle_Click(object sender, EventArgs e)
        {
            if (gizliMi == false)
            {
                txtSifreniz.UseSystemPasswordChar = true;
                gizliMi = true;
            }

            else if (gizliMi == true)
            {
                txtSifreniz.UseSystemPasswordChar = false;
                gizliMi = false;
            }
        }
    }
}
