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
      
        public int MakroDegerID { get; set; }
        public double KarbonhidratMiktari { get; set; }
        public double YagMiktari { get; set; }
        public double ProteinMiktari { get; set; }
        public Besin Besin { get; set; }
    }
}

