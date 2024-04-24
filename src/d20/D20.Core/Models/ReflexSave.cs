namespace D20.Core.Models
{
    public class ReflexSave : SavingThrow
    {
        /// <summary>
        /// Reflex Save
        /// </summary>
        /// <param name="creature">The creature the save is for</param>
        public ReflexSave(Creature creature)
            : base(creature, creature.Dexterity)
        {
            Name = "Reflex Save";
            Description = "These saves test your ability " +
                "to dodge area attacks and unexpected " +
                "situations. Apply your Dexterity " +
                "modifier to your Reflex saving throws.";
        }
    }
}
