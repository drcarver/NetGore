using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models
{
    public class Skill : BaseObject, ISkill
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [SetsRequiredMembers]
        public Skill()
        {
        }
    }
}