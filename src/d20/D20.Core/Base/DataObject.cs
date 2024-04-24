using System;
using System.ComponentModel;

using D20.Core.Interfaces;

namespace D20.Core.Base
{
    /// <summary>
    /// The base object for all data models
    /// </summary>
    public class DataObject : BaseObject, IDataObject
    {
        /// <summary>
        /// Is the object marked for deletion?
        /// </summary>
        [Description("Is the object marked for deletion?")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Date and Time the object was created
        /// </summary>
        [Description("Date and Time the object was created")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date and Time the object was last updated
        /// </summary>
        [Description("Date and Time the object was last updated")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataObject()
        {
            UpdatedAt = DateTime.UtcNow;
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }
    }
}
