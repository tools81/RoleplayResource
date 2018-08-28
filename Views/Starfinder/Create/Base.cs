using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rules.Starfinder;
using Storage.Starfinder;
using Storage;

namespace Views.Starfinder.Create
{
    public partial class Base : UserControl
    {
        Character _character;
        private DescriptionControl _descriptionControl;
        private AbilityScoreControl _abilityScoreControl;
        private SkillControl _skillControl;
        private InitiativeControl _initControl;
        private HealthControl _healthControl;
        private ArmorControl _armorControl;
        private AttackControl _attackControl;
        private SavingThrowControl _savingThrowControl;
        private AbilitiesControl _abilitiesControl;
        private FeatsControl _featsControl;
        private WeaponsControl _weaponsControl;
        private EquipmentControl _equipmentControl;
        private WearableControl _wearableControl;
        private SpellsControl _spellsControl;
        private SummaryControl _summaryControl;

        public Base(string characterName)
        {
            InitializeComponent();

            if (characterName == null)
                _character = CreateCharacter.GetNewCharacter();
            else
                _character = CreateCharacter.LoadCharacter(characterName);

            _descriptionControl = new DescriptionControl(_character, this);
            _abilityScoreControl = new AbilityScoreControl(_character, this);            
            _initControl = new InitiativeControl(_character, this);
            _healthControl = new HealthControl(_character, this);            
            _attackControl = new AttackControl(_character, this);
            _savingThrowControl = new SavingThrowControl(_character, this);
            _abilitiesControl = new AbilitiesControl(_character, this);
            _featsControl = new FeatsControl(_character, this);
            _weaponsControl = new WeaponsControl(_character, this);
            _equipmentControl = new EquipmentControl(_character, this);
            _wearableControl = new WearableControl(_character, this);
            _armorControl = new ArmorControl(_character, this);
            _skillControl = new SkillControl(_character, this);
            _spellsControl = new SpellsControl(_character, this);
            _summaryControl = new SummaryControl(_character, this);

            pnlTopLeft.Controls.Add(_descriptionControl);
            pnlBottomLeft.Controls.Add(_abilityScoreControl);
            pnlMiddle.Controls.Add(_skillControl);
            pnlInitiative.Controls.Add(_initControl);
            pnlHealth.Controls.Add(_healthControl);
            pnlArmor.Controls.Add(_armorControl);
            pnlAttackBonus.Controls.Add(_attackControl);
            pnlSavingThrows.Controls.Add(_savingThrowControl);
            pnlAbilities.Controls.Add(_abilitiesControl);
            pnlFeats.Controls.Add(_featsControl);
            pnlWeapons.Controls.Add(_weaponsControl);
            pnlEquipment.Controls.Add(_equipmentControl);
            pnlWearables.Controls.Add(_wearableControl);
            pnlSpells.Controls.Add(_spellsControl);
            pnlSummary.Controls.Add(_summaryControl);
        }

        private void PopulateControlValues()
        {
            if (_descriptionControl != null) _descriptionControl.PopulateValues(_character);
            if (_abilityScoreControl != null) _abilityScoreControl.PopulateValues(_character.AbilityScores);
            if (_initControl != null) _initControl.PopulateValues(_character.Init);
            if (_healthControl != null) _healthControl.PopulateValues(_character.Health);
            if (_attackControl != null) _attackControl.PopulateValues(_character.Attack);
            if (_savingThrowControl != null) _savingThrowControl.PopulateValues(_character.SavingThrow);
            if (_abilitiesControl != null) _abilitiesControl.PopulateValues(_character.Abilities);
            if (_featsControl != null) _featsControl.PopulateValues(_character.Feats);
            if (_weaponsControl != null) _weaponsControl.PopulateValues(_character.Weapons);
            if (_equipmentControl != null) _equipmentControl.PopulateValues(_character.Equipments);
            if (_wearableControl != null) _wearableControl.PopulateValues(_character);
            if (_armorControl != null) _armorControl.PopulateValues(_character.ArmorClass);
            if (_skillControl != null) _skillControl.PopulateValues(_character.Skills, _character.SkillPointsPerLevel);
            if (_spellsControl != null) _spellsControl.PopulateValues(_character.Spells);
            if (_summaryControl != null) _summaryControl.PopulateValues(_character);
        }

        public void UpdateCharacter(Character character)
        {
            CreateCharacter.UpdateCharacter(character);
            PopulateControlValues();
        }
    }
}
