using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class Attack
    {
        public int AttackBonus { get; set; }
        public int StrengthMod { get; set; }
        public int DexMod { get; set; }
        public int MiscMeleeMod { get; set; }
        public int MiscRangedMod { get; set; }
        public int MiscThrownMod { get; set; }
        public int MeleeAttackBonus {
            get
            {
                return AttackBonus + StrengthMod + MiscMeleeMod;
            }
        }
        public int RangedAttackBonus
        {
            get
            {
                return AttackBonus + DexMod + MiscRangedMod;
            }
        }
        public int ThrownAttackBonus
        {
            get
            {
                return AttackBonus + StrengthMod + MiscThrownMod;
            }
        }
    }
}
