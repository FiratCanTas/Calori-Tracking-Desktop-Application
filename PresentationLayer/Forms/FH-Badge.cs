using DataAccessLayer.Context;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FH_Badge : Form
    {
        public FH_Badge()
        {
            InitializeComponent();
        }

        FatHunterDbContext db = new FatHunterDbContext();
        private void FH_Badge_FormClosed(object sender, FormClosedEventArgs e)
        {
            FH_SignIn.userMainPage.Show();
        }
        int toplamKullanim = 0;
        private void FH_Badge_Load(object sender, EventArgs e)
        {
            var kullaniciYaratilmaTarihiniBul = db.Kullanıcılar.Where(x => x.KullanıcıMail == FH_MainPage.fH_SignIn.txtEmailAdresiniz.Text && x.KullanıcıŞifre == FH_MainPage.fH_SignIn.txtSifreniz.Text).Select(x => x.CreatedDate).FirstOrDefault();

            if (kullaniciYaratilmaTarihiniBul != null)
            {
                toplamKullanim = (Convert.ToInt32(DateTime.Today - kullaniciYaratilmaTarihiniBul));

                if (toplamKullanim >= 7)
                {
                    btnHevesli.Enabled = true;
                }
                if (toplamKullanim >= 14)
                {
                    btnİradeli.Enabled = true;
                }
                if (toplamKullanim >= 21)
                {
                    btnİstikrarlı.Enabled = true;
                }
            }
        }

        private void btnHevesli_Click(object sender, EventArgs e)
        {
            if (btnHevesli.Enabled == false)
            {
                MessageBox.Show("Henüz bu rozete sahip değilsiniz.");
            }
            else
            {
                MessageBox.Show("Rozeti başarıyla kazandınız!");
            }
        }

        private void btnİradeli_Click(object sender, EventArgs e)
        {
            if (btnİradeli.Enabled == false)
            {
                MessageBox.Show("Henüz bu rozete sahip değilsiniz.");
            }
            else
            {
                MessageBox.Show("Rozeti başarıyla kazandınız!");
            }
        }

        private void btnİstikrarlı_Click(object sender, EventArgs e)
        {
            if (btnİstikrarlı.Enabled == false)
            {
                MessageBox.Show("Henüz bu rozete sahip değilsiniz.");
            }
            else
            {
                MessageBox.Show("Rozeti başarıyla kazandınız!");
            }
        }
    }
}
