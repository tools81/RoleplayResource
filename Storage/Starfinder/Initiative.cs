using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class Initiative
    {        
        public int DexMod { get; set; }
        public int MiscMod { get; set; }
        public int Total {
            get
            {
                return DexMod + MiscMod;
            }
        }
    }
}
