using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface ITuketilenBesin
    {
        Ogunler BesininTüketildiğiÖğün { get; set; }
        int BesinMakroID { get; set; }
        DateTime TüketilenTarih { get; set; }
        int İçilenSuMiktarı { get; set; }



        //Bir kullanıcı tarafından tüketilir
        Kullanici Kullanıcı { get; set; }
        int KullanıcıID { get; set; }
    }
}
