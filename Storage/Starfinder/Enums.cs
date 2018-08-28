using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class Enums
    {
        public enum AbilityScores
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }

        public enum Skills
        {
            Acrobatics,
            Athletics,
            Bluff,
            Computers,
            Culture,
            Diplomacy,
            Disguise,
            Engineering,
            Intimidate,
            LifeScience,
            Medicine,
            Mysticism,
            Perception,
            PhysicalScience,
            Piloting,
            Profession1,
            Profession2,
            SenseMotive,
            SleightOfHand,
            Stealth,
            Survival
        }

        public enum SavingThrows
        {
            Fortitude,
            Reflex,
            Will
        }

        public enum ArmorClass
        {
            Energy,
            Kinetic,
            Maneuver
        }

        public enum ArmorType
        {
            Light,
            Heavy,
            Powered
        }

        public enum AttackBonuses
        {
            Melee,
            Ranged,
            Thrown
        }

        public enum Gender
        {
            Male,
            Female,
            Neutral
        }

        public enum CharacterSize
        {
            Small,
            Medium,
            Large
        }

        public enum Alignment
        {
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            Neutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil
        }

        public enum WeaponType
        {
            BasicMelee,
            AdvancedMelee,
            SmallArms,
            LongArms,
            Heavy,
            Grenade,
            Sniper,
            Special
        }

        public enum WeaponCategory
        {
            Cryo,
            Flame,
            Laser,
            Operative,
            Plasma,
            Projectile,
            Shock,
            Sonic,
            Uncategorized
        }

        public enum WeaponSpecial
        {
            Analog,
            Archaic,
            Automatic,
            Blast,
            Block,
            Boost1D4,
            Boost1D6,
            Boost1D8,
            Boost1D10,
            Boost2D4,
            Boost2D6,
            Boost2D8,
            Boost2D10,
            Bright,
            Disarm,
            Explode5,
            Explode10,
            Explode15,
            Explode20,
            Injection,
            Line,
            Nonlethal,
            Operative,
            Penetrating,
            Powered,
            QuickReload,
            Reach,
            Sniper250,
            Sniper500,
            Sniper750,
            Sniper1000,
            Stun,
            Thrown,
            Trip,
            Unwieldy
        }

        public enum Critical
        {
            Arc1D4,
            Arc1D6,
            Arc2D4,
            Arc2D6,
            Arc3D4,
            Arc4D6,
            Arc6D4,
            Arc6D6,
            Bleed1D4,
            Bleed1D6,
            Bleed1D8,
            Bleed2D6,
            Bleed2D8,
            Bleed3D8,
            Bleed5D6,
            Bleed6D6,
            Burn1D4,
            Burn1D6,
            Burn1D8,
            Burn1D10,
            Burn2D4,
            Burn2D6,
            Burn2D8,
            Burn2D10,            
            Burn3D4,
            Burn3D8,
            Burn4D4,
            Burn4D6,
            Burn4D8,
            Burn5D4,
            Burn5D6,
            Burn6D6,
            Burn9D6,
            Corrode1D4,
            Corrode2D4,
            Corrode4D4,
            Deafen,
            Injection,
            Knockdown,
            SevereWound,
            Staggered,
            Stunned,
            Wound
        }

        public enum ResistanceType
        {
            Acid,
            Cold,
            Electricity,
            Fire,
            Sonic
        }

        public enum BonusType
        {
            Ability,
            AbilityScore,
            Armor,
            Attack,
            Base,
            ClassSkill,
            Damage,
            Feat,
            Health,                        
            Initiative,
            Resolve,
            SavingThrows,
            Skill,
            SkillRank,
            Speed,
            Spell
        }
    }
}
