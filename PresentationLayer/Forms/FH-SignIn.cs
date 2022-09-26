using DataAccessLayer.Context;
using EntityLayer.Abstract;
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
        public static Kullanici user;
        public static double bmr;
        public static double tdee;
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
            user = dbContext.Kullanıcılar.Where(x => x.KullanıcıMail == txtEmailAdresiniz.Text && x.KullanıcıŞifre == txtSifreniz.Text).FirstOrDefault();

            userMainPage.lblKaloriHedefDegeri.Text = KaloriHesapla(tdee, bmr).ToString();

            foreach (Kullanici kullanici in dbContext.Kullanıcılar)
            {
                if (kullanici.KullanıcıMail == txtEmailAdresiniz.Text && kullanici.KullanıcıŞifre == txtSifreniz.Text)
                {
                    this.Hide();
                    userMainPage.Show();
                }
                else
                {
                    MessageBox.Show("E-Mail adresi ya da şifre hatalı!");
                }
            }
        }

        public double KaloriHesapla(double tdee, double bmr)
        {
            if (user.Cinsiyet == Cinsiyet.Erkek)
            {
                bmr = 66.5 + (13.75 * user.MevcutAğırlık) + (5.03 * user.Boy) - (6.75 * (Convert.ToInt32(DateTime.Now.Year) - user.Yas));
            }
            else
            {
                bmr = 655.1 + (9.56 * user.MevcutAğırlık) + (1.85 * user.Boy) - (4.68 * (Convert.ToInt32(DateTime.Now.Year) - user.Yas));
            }

            if (user.AktiviteDüzeyi == "Hareketsiz Yaşam Tarzına Sahibim")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.2) + 700;
                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.2) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.2;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.2) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.2) - 700;
                }
            }

            else if (user.AktiviteDüzeyi == "Haftada 1-2 Gün Spor Yapıyorum")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.4) + 700;

                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.4) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.4;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.4) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.4) - 700;
                }
            }
            else if (user.AktiviteDüzeyi == "Haftada 2-3 Gün Spor Yapıyorum")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.5) + 700;

                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.5) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.5;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.5) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.5) - 700;
                }
            }
            else if (user.AktiviteDüzeyi == "Haftada 4-5 Gün Spor Yapıyorum")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.6) + 700;

                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.6) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.6;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.6) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.6) - 700;
                }
            }
            else if (user.AktiviteDüzeyi == "Haftada 6-7 Gün Spor Yapıyorum")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.7) + 700;

                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.7) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.7;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.7) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.7) - 700;
                }
            }
            else if (user.AktiviteDüzeyi == "Günde 2 Defa Spor Yapıyorum")
            {
                if (user.DiyetHedefi == "Hızlı Kilo Alımı")
                {
                    tdee = (bmr * 1.8) + 700;
                }
                else if (user.DiyetHedefi == "Kilo Alımı")
                {
                    tdee = (bmr * 1.8) + 500;
                }
                else if (user.DiyetHedefi == "Kilomu Koru")
                {
                    tdee = bmr * 1.8;
                }
                else if (user.DiyetHedefi == "Kilo Kaybı")
                {
                    tdee = (bmr * 1.8) - 500;
                }
                else if (user.DiyetHedefi == "Hızlı Kilo Kaybı")
                {
                    tdee = (bmr * 1.8) - 700;
                }
            }
            return tdee;
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
