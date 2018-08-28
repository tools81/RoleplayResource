using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class SavingThrow
    {
        public int BaseFortitude { get; set; }
        public int BaseReflex { get; set; }
        public int BaseWill { get; set; }
        public int MiscFortitudeMod { get; set; }
        public int MiscReflexMod { get; set; }
        public int MiscWillMod { get; set; }
        public int ConMod { get; set; }
        public int DexMod { get; set; }
        public int WisMod { get; set; }
        public int FortitudeSave
        {
            get
            {
                return BaseFortitude + MiscFortitudeMod + ConMod;
            }
        }
        public int ReflexSave
        {
            get
            {
                return BaseReflex + MiscReflexMod + DexMod;
            }
        }
        public int WillSave
        {
            get
            {
                return BaseWill + MiscWillMod + WisMod;
            }
        }
    }
}
