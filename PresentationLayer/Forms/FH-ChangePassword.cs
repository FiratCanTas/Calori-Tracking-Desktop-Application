using DataAccessLayer.Context;
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
    public partial class FH_ChangePassword : Form
    {
        public FH_ChangePassword()
        {
            InitializeComponent();
        }
        FatHunterDbContext dbContext;

        private void FH_ChangePassword_Load(object sender, EventArgs e)
        {
            dbContext = new FatHunterDbContext();
        }

        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            var sifreGuncellenecekKisi = dbContext.Kullanıcılar.Where(x => x.KullanıcıMail == txtEmail.Text).Where(x => x.Adı == txtAdiniz.Text).Where(x => x.Soyadı == txtSoyadiniz.Text).FirstOrDefault();

            sifreGuncellenecekKisi.KullanıcıŞifre = txtYeniSifre.Text;

            FH_MainPage.fH_SignIn.Show();
            this.Hide();
        }

        private void FH_ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }
    }
}
