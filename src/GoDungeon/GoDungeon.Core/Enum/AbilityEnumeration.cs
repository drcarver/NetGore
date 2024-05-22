namespace GoDungeon.Core.Enum
{
    public class AbilityEnumeration : Enumeration
    {
        public static readonly AbilityEnumeration Strength
            = new AbilityEnumeration("Strength", "STR");
        public static readonly AbilityEnumeration Constitution
            = new AbilityEnumeration("Constitution", "CON");
        public static readonly AbilityEnumeration Intelligence
            = new AbilityEnumeration("Intelligence", "INT");
        public static readonly AbilityEnumeration Wisdom
            = new AbilityEnumeration("Wisdom", "WIS");
        public static readonly AbilityEnumeration Dexterity
            = new AbilityEnumeration("Dexterity", "DEX");
        public static readonly AbilityEnumeration Charisma
            = new AbilityEnumeration("Charisma", "CHA");

        public string Abbreviation => _abbreviation;

        public int Score { get; set; }

        private string _abbreviation;

        private AbilityEnumeration() 
        {
            _abbreviation = string.Empty;
        }
        private AbilityEnumeration(int value, string displayName) : base(value, displayName) 
        {
            _abbreviation = string.Empty;
        }
        private AbilityEnumeration(string displayName) : base(displayName) 
        {
            _abbreviation = string.Empty;
        }
        private AbilityEnumeration(string displayName, string abbreviation) : base(displayName) 
        {
            _abbreviation = abbreviation;
        }
        private AbilityEnumeration(string displayName, string abbreviation, string description) 
            : base(displayName, description)
        {
            _abbreviation = abbreviation;
        }
    }
}