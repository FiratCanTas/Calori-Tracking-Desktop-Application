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
    public partial class FH_ClarificationText : Form
    {
        public FH_ClarificationText()
        {
            InitializeComponent();
        }

        FH_MainPage mainPage;
        FH_SignIn signIn;

        private void btnRedEdiyorum_Click(object sender, EventArgs e)
        {
            mainPage = new FH_MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void FH_ClarificationText_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }

        private void btnKabul_Click(object sender, EventArgs e)
        {
            FH_SignUp.yeniKullanici.CreatedDate = DateTime.Today;
            FH_SignUp.db.Kullanıcılar.Add(FH_SignUp.yeniKullanici);
            FH_SignUp.db.SaveChanges();

            signIn = new FH_SignIn();
            signIn.Show();

            if (FH_SignUp.yeniKullanici.KullanıcıŞifre != "0" && FH_SignUp.yeniKullanici.Yas != 0 && FH_SignUp.yeniKullanici.KullanıcıMail != "0")
            {
                FH_SignUp.yeniKullanici.CreatedDate = DateTime.Today;
                FH_SignUp.db.Kullanıcılar.Add(FH_SignUp.yeniKullanici);
                FH_SignUp.db.SaveChanges();
                
            }
            UserMainPage userMainPage = new UserMainPage();
            userMainPage.Show();

            this.Hide();

            

        }
    }
}
