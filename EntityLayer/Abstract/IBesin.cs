using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IBesin
    {
        int BesinID { get; set; }
        string BesinAdı { get; set; }
        int BesinGramajı { get; set; }
        int BesinAdedi { get; set; }
        int BesinKalorisi { get; set; }

        //Makro Tablo baglantı
        MakroDeger MakroDeger { get; set; }
        int MakroDegerID { get; set; }

        //Tuketilen Besin tablo baglanti
        
        int TuketilenBesinId { get; set; }
        ICollection<TuketilenBesin> TuketilenBesinler { get; set; }

    }
}
