using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Besin : IBesin
    {
        public int BesinID { get; set; }
        public string BesinAdı { get; set; }
        public int BesinGramajı { get; set; }
        public int BesinAdedi { get; set; }
        public int BesinKalorisi { get; set; }
        public int MakroDegerID { get; set; }
        public MakroDeger MakroDeger { get; set; }
        public Ogunler? BesininTuketildigiOgun { get; set; }
        public DateTime? TüketilenTarih { get; set; }
    }
}

