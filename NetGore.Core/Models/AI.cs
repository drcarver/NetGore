using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models
{
    public class AI : BaseObject, IAI
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [SetsRequiredMembers]
        public AI()
        {
        }
    }
}