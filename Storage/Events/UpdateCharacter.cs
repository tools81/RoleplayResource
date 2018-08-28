using System;
using Storage;
using Storage.Interfaces;


namespace Rules.Events
{
    public delegate void UpdateCharacterDelegate(UpdateCharacterArgs e);
    public class UpdateCharacter
    {
    }

    public class UpdateCharacterArgs : EventArgs
    {
        public Enums.Ruleset _ruleset;
        public ICharacter _character;

        public UpdateCharacterArgs(Enums.Ruleset ruleset, ICharacter character)
        {
            this._ruleset = ruleset;
            this._character = character;
        }
    }

    public class UpdateCharacterListener
    {
        public void Handle(UpdateCharacterArgs e)
        {
            switch (e._ruleset)
            {
                case Enums.Ruleset.Pathfinder:
                    break;
                case Enums.Ruleset.Starfinder:
                    //Storage.Starfinder.Character.UpdateCharacter(e);
                    break;
                case Enums.Ruleset.WorldOfDarkness:
                    break;
                default:
                    break;
            }
        }
    }
}
