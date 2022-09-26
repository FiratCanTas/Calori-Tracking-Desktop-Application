using EntityLayer.Concrete;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface ITuketilenUrunler
    {
        int TuketilenID { get; set; }
        List<Besin> Tuketilenler { get; set; }
        DateTime TuketildigiTarih { get; set; }
        int TuketilenKalori { get; set; }
        int KullanıcıID { get; set; }
        int IcilenSu { get; set; }
    }
}
