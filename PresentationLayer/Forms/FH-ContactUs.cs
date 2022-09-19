using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PresentationLayer.Forms
{
    public partial class FH_ContactUs : Form
    {
        public FH_ContactUs()
        {
            InitializeComponent();
        }

        private void FH_ContactUs_Load(object sender, EventArgs e)
        {
        }

        private void btnIletiGönder_Click(object sender, EventArgs e)
        {
            IletisimFormlari form = new IletisimFormlari()
            {
                KullanıcıAdi = txtAdiniz.Text,
                MailAdresi = txtEmailAdresiniz.Text,
                Konu = txtKonu.Text,
                OneriSikayet = txtMesaj.Text,
            };

            var kullanıcı = FH_MainPage.dbContext.Kullanıcılar.Where(x => x.KullanıcıMail == txtEmailAdresiniz.Text).FirstOrDefault();

            form.KullanıcıID = kullanıcı.KullanıcıID;

            FH_MainPage.dbContext.IletisimFormlari.Add(form);
            FH_MainPage.dbContext.SaveChanges();

            var result = MessageBox.Show("Yeni Form Oluşturmak ister misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
                FH_MainPage.fH_SignIn.Show();
            }
            else
            {
                Clear();
            }
        }

        public void Clear()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    ((CheckBox)item).Enabled = false;
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value= DateTime.Today;
                }
            }
        }
    }
}
