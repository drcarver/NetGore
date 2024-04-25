using System;
using System.Collections.Generic;

using D20.Background.Enum;
using D20.Background.Interfaces;
using D20.Core.Models;

namespace D20.Background.Models
{
    public class BackgroundTableEntry : RandomTableEntry, IBackgroundTableEntry
    {
        /// <summary>
        /// The racial traits for this creature 
        /// </summary>
        public List<TraitEnum> Traits { get; set; } = [];

        /// <summary>
        /// The alternate table
        /// </summary>
        public Type? AlternateTable { get; set; }
    }
}
