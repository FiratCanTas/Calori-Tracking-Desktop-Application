using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLayer.Concrete
{
    public class Kullanici : IKullanici,IBaseEntity
    {
       
        public int KullanıcıID { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string NickName { get; set; }

        string kullaniciMail;
        public string KullanıcıMail { get { return kullaniciMail; }
            set
            {
                if (value.Contains("@gmail.com") || value.Contains("@windowslive.com") || value.Contains("@hotmail.com") || value.Contains("@outlook.com") || value.Contains("@yahoo.com"))
                {
                    kullaniciMail = value;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!");
                    value = "0";
                    kullaniciMail = value;
                }
            } }

        string kullaniciSifre;
        public string KullanıcıŞifre { get { return kullaniciSifre; }
            set
            {
                char[] sifre = value.ToCharArray();
                int ayniDeger = 0;

                if (value.Length >= 6 )
                {
                    for (int i = 0; i < sifre.Length; i++)
                    {
                        for (int k = sifre.Length-1; k > 0; k--)
                        {
                            if (sifre[i] == sifre[k])
                            {
                                ayniDeger++;
                            }


                        }
                      
                    }

                    if (ayniDeger <= ((value.Length)/0.7))
                    {
                        kullaniciSifre = value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Şifre içerisinde çok fazla tekrar eden alan var!");
                        value = "0";
                        kullaniciSifre = value;
                    }
                }
                else
                {
                    MessageBox.Show("Şifre en az 6 karakterden oluşmalı!");
                    value = "0";
                    kullaniciSifre = value;
                }
                
            } }
        public double Boy { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        //public List<TuketilenBesin> TüketilenBesinler { get; set; }

        int yas;
        public int Yas { get { return yas; } 
            set
            {
                if (value != DateTime.Now.Year)
                {
                    yas = DateTime.Now.Year - value;
                }
                else
                {
                    MessageBox.Show("Dogum tarihi bilgisini kontrol ediniz!");
                    value = 0;
                    yas = value;
                }
                  

            }
        }
        public double MevcutAğırlık { get; set; }
        
        public string AktiviteDüzeyi { get; set; }
        public string DiyetHedefi { get; set; }
        public double HedefAgırlıgı { get; set; }
        public List<IletisimFormlari> IletisimFormlari { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; }
       
    }
}
