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
    public partial class FH_SignUp : Form
    {
        public FH_SignUp()
        {
            InitializeComponent();
           
        }

        FH_ClarificationText fH_ClarificationText;
        public static FatHunterDbContext db = new FatHunterDbContext();
        public static Kullanici yeniKullanici = new Kullanici();
        public double bmr;
        public double tdee;
        private void btnIptal_Click(object sender, EventArgs e)
        {    
            //Clear(); KATMANLIDA BASE İÇERSİNDE OLUŞACAK
            this.Hide();
            FH_MainPage.page.Show();
            
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            
            yeniKullanici.Adı = txtAdiniz.Text;
            yeniKullanici.Soyadı = txtSoyadiniz.Text;
            yeniKullanici.Yas = Convert.ToInt32(dtpDogumTarihi.Value.Year);
            yeniKullanici.Boy = Convert.ToDouble( txtBoyunuz.Text);
            yeniKullanici.MevcutAğırlık = Convert.ToDouble( txtKilonuz.Text);
            yeniKullanici.AktiviteDüzeyi = cmbAktiviteDuzeyi.SelectedItem.ToString();
            yeniKullanici.Cinsiyet = (rdbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın);
            yeniKullanici.DiyetHedefi = cmbDiyetHedefiniz.SelectedItem.ToString();
            yeniKullanici.HedefAgırlıgı = Convert.ToDouble( txtHedefAgirlik.Text);
            yeniKullanici.KullanıcıMail = txtEmailAdresiniz.Text;
            yeniKullanici.KullanıcıŞifre = txtSifreniz.Text;
            yeniKullanici.NickName = txtKullaniciAdi.Text;

            if (yeniKullanici.Cinsiyet == Cinsiyet.Erkek)
            {
                bmr = 66.5 + ((13.75) * yeniKullanici.MevcutAğırlık) + (5.03 * yeniKullanici.Boy) - (6.75 * yeniKullanici.Yas); 
            }
            else if (yeniKullanici.Cinsiyet == Cinsiyet.Kadın)
            {
                bmr = 655.1 + (9.56 * yeniKullanici.MevcutAğırlık) + (1.85 * yeniKullanici.Boy) - (4.68 * yeniKullanici.Yas);
            }


            if (yeniKullanici.AktiviteDüzeyi == "Hareketsiz Yaşam Tarzına Sahibim")
            {
                tdee = bmr * 1.2;
            }
            else if (yeniKullanici.AktiviteDüzeyi == "Haftada 1-2 Gün Spor Yapıyorum")
            {

            }
            else if (yeniKullanici.AktiviteDüzeyi == " Haftada 2 - 3 Gün Spor Yapıyorum")
            {

            }
            else if (yeniKullanici.AktiviteDüzeyi == "Haftada 4 - 5 Gün Spor Yapıyorum")
            {

            }
            else if (yeniKullanici.AktiviteDüzeyi == "Haftada 6 - 7 Gün Spor Yapıyorum")
            {

            }
            else if (yeniKullanici.AktiviteDüzeyi == " Günde 2 Defa Spor Yapıyorum")
            {

            }



                  var kullaniciVarMi = db.Kullanıcılar.Select(x => x.NickName).ToList();

            foreach (var item in kullaniciVarMi)
            {
                if (txtKullaniciAdi.Text == item)
                {
                    MessageBox.Show("Bu kullanici adı ile kayıt yapılmış! Lütfen başka bir ad seçiniz.");
                }
            }


            if (yeniKullanici.KullanıcıŞifre != "0" && yeniKullanici.Yas != 0 && yeniKullanici.KullanıcıMail != "0")
            {
               
                fH_ClarificationText = new FH_ClarificationText();
                fH_ClarificationText.Show();
                this.Hide();
            }


        }

        private void FH_SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
        bool gizliMi;
        private void FH_SignUp_Load(object sender, EventArgs e)
        {
            gizliMi = false;
            cmbAktiviteDuzeyi.SelectedText = "Hareketsiz Yaşam Tarzına Sahibim";
            cmbAktiviteDuzeyi.SelectedItem = "Hareketsiz Yaşam Tarzına Sahibim";
            cmbDiyetHedefiniz.SelectedText = "Kilomu Koru";
            cmbDiyetHedefiniz.SelectedItem = "Kilomu Koru";
            
            rdbErkek.Checked = true;
        }

        private void aktiviteDuzeyiAciklama_Click(object sender, EventArgs e)
        {
            FH_ExerciseAnnotation aciklama = new FH_ExerciseAnnotation();
            aciklama.Show();
            
        }
    }
}
