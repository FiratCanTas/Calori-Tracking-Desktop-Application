using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IMakroDeger
    {
        int BesinMakroID { get; set; }
        int BesinID { get; set; }
        int KarbonhidratMiktari { get; set; }
        int YagMiktari { get; set; }
        int ProteinMiktari { get; set; }
    }
}
