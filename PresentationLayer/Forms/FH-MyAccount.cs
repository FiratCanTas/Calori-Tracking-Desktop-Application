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
    public partial class FH_MyAccount : Form
    {
        public FH_MyAccount()
        {
            InitializeComponent();
        }
        FatHunterDbContext Db = new FatHunterDbContext();

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FH_SignIn.userMainPage.Show();
            this.Close();
            Kullanici kullanici = new Kullanici();
            
            //var guncellenecekKisi = Db.Kullanıcılar.Where(x=>x.)

            kullanici.MevcutAğırlık = Convert.ToDouble(txtKilonuz.Text);
            kullanici.Boy = Convert.ToDouble(txtBoyunuz.Text);
            kullanici.AktiviteDüzeyi = cmbAktiviteDüzeyi.SelectedItem.ToString(); ;  // comboboxın selectedindex veya selecteditem i yapmalı mıyız ?
            kullanici.DiyetHedefi = cmbDiyetHedefiniz.Text;
            kullanici.HedefAgırlıgı = Convert.ToInt32(txtHedefAgirlik.Text);
            kullanici.KullanıcıMail = txtEmailAdresiniz.Text;
            kullanici.KullanıcıŞifre = txtSifreniz.Text;
            Db.Kullanıcılar.Add(kullanici);
            Db.SaveChanges();
        }

        
    }
}
