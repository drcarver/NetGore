namespace D20.Core.Models
{
    public class WillSave : SavingThrow
    {
        /// <summary>
        /// Will Save
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="creature">The creature the save is for</param>
        public WillSave(Creature creature)
            : base(creature, creature.Wisdom)
        {
            Name = "Will Save";
            Description = "These saves reflect your " +
                "resistance to mental influence as well " +
                "as many magical effects. Apply your " +
                "Wisdom modifier to your Will saving throws.";
        }
    }
}
