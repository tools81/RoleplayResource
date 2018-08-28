using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class ArmorClass
    {
        public int ArmorBonusEnergy { get; set; }
        public int ArmorBonusKinetic { get; set; }
        public int DexMod { get; set; }
        public int MiscEnergyMod { get; set; }
        public int MiscKineticMod { get; set; }
        public int DamageReduction { get; set; }
        public int MiscDamageReductionMod { get; set; }
        public List<Resistance> Resistances { get; set; }
        public int WearableKineticBonus { get; set; }
        public int WearableEnergyBonus { get; set; }
        public int TotalEnergyBonus
        {
            get
            {
                return ArmorBonusEnergy + WearableEnergyBonus;
            }
        }
        public int TotalKineticBonus
        {
            get
            {
                return ArmorBonusKinetic + WearableKineticBonus;
            }
        }
        public int EnergyArmorClass
        {
            get
            {
                return 10 + ArmorBonusEnergy + DexMod + MiscEnergyMod + WearableEnergyBonus;
            }
        }
        public int KineticArmorClass {
            get
            {
                return 10 + ArmorBonusKinetic + DexMod + MiscKineticMod + WearableKineticBonus;
            }
        }
        public int ManeuversArmorClass
        {
            get
            {
                return 8 + KineticArmorClass;
            }
        }

        public ArmorClass()
        {
            Resistances = new List<Resistance>();
        }
    }
}
