using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IMakroDeger
    {
        int MakroDegerID { get; set; }

        //Besin tablo baglanti
        Besin Besin { get; set; }
        double KarbonhidratMiktari { get; set; }
        double YagMiktari { get; set; }
        double ProteinMiktari { get; set; }
    }
}
