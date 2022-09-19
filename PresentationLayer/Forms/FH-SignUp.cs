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
        FatHunterDbContext db = new FatHunterDbContext();
        private void btnIptal_Click(object sender, EventArgs e)
        {    
            //Clear(); KATMANLIDA BASE İÇERSİNDE OLUŞACAK
            this.Hide();
            FH_MainPage.page.Show();
            
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Adı = txtAdiniz.Text;
            yeniKullanici.Soyadı = txtSoyadiniz.Text;
            yeniKullanici.Yas =  Convert.ToInt32(Convert.ToInt32((DateTime.Now.Year) - dtpDogumTarihi.Value.Year));
            yeniKullanici.Boy = Convert.ToInt32( txtBoyunuz.Text);
            yeniKullanici.MevcutAğırlık = Convert.ToInt32( txtKilonuz.Text);
            yeniKullanici.AktiviteDüzeyi = cmbAktiviteDuzeyi.SelectedItem.ToString();
            yeniKullanici.Cinsiyet = (rdbErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın);
            yeniKullanici.DiyetHedefi = cmbDiyetHedefiniz.SelectedItem.ToString();
            yeniKullanici.HedefAgırlıgı = Convert.ToInt32( txtHedefAgirlik.Text);
            yeniKullanici.KullanıcıMail = txtEmailAdresiniz.Text;
            yeniKullanici.KullanıcıŞifre = txtSifreniz.Text;

            if (yeniKullanici.KullanıcıŞifre != "0")
            {
                db.Kullanıcılar.Add(yeniKullanici);
                db.SaveChanges();
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
            cmbDiyetHedefiniz.SelectedText = "Kilomu Koru";
            rdbErkek.Checked = true;
        }

        private void aktiviteDuzeyiAciklama_Click(object sender, EventArgs e)
        {
            FH_ExerciseAnnotation aciklama = new FH_ExerciseAnnotation();
            aciklama.Show();
            
        }
    }
}
