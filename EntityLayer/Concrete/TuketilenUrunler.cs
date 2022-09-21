using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TuketilenUrunler
    {
        public TuketilenUrunler()
        {
            Tuketilenler = new List<Besin>();
        }
        public List<Besin> Tuketilenler { get; set; }
        public DateTime TuketildigiTarih { get; set; }
        public int TuketilenKalori { get; set; }
        public int KullanıcıID { get; set; }
    }
}
