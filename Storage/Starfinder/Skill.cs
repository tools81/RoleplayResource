using System;


namespace Storage.Starfinder
{
    public class Skill
    {
        public Enums.Skills Name { get; set; }
        public int Rank { get; set; }
        public int ClassBonus { get; set; }
        public int MiscMod { get; set; }
        public Enums.AbilityScores Ability { get; set; }
        public bool ClassSkill { get; set; }
        public int Total { get; set; }
    }
}
