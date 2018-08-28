using Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Starfinder
{
    public class AbilityScore : IBaseModel
    {
        public Enums.AbilityScores Name { get; set; }
        public string Abbreviation { get; set; }
        public int Score { get; set; }
        public int ScoreBonus { get; set; }
        public int Mod
        {
            get
            {
                return ((Score + ScoreBonus - 10) / 2);
            }
        }
    }
}
