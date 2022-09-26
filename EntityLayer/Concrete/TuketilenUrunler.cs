using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TuketilenUrunler : ITuketilenUrunler
    {
        public TuketilenUrunler()
        {
            Tuketilenler = new List<Besin>();
        }
        [Key]
        public int TuketilenID { get; set; }
        public List<Besin> Tuketilenler { get; set; }
        public DateTime TuketildigiTarih { get; set; }
        public int TuketilenKalori { get; set; }
        public int KullanıcıID { get; set; }
        public int IcilenSu { get; set; }
    }
}
