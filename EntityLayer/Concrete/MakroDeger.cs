using EntityLayer.Abstract;
using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MakroDeger : IMakroDeger
    {
        public int BesinMakroID { get; set; }
        public int BesinID { get; set; }
        public int KarbonhidratMiktari { get; set; }
        public int YagMiktari { get; set; }
        public int ProteinMiktari { get; set; }
        public Besin Besin { get; set; }
    }
}

