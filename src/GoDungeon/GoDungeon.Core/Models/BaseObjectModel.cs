using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.Models
{
    /// <summary>
    /// The base object for all models
    /// </summary>
    public partial class BaseObjectModel : IBaseObject
    {
        /// <summary>
        /// The Id for the object
        /// </summary>
        [Key]
        public Guid? Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// The name of the object
        /// </summary>
        [MaxLength(80)]
        [MinLength(4)]
        [Description("The Name of the object.")]
        public string? Name { get; set; }

        /// <summary>
        /// The Description of the object
        /// </summary>
        [Description("The Description of the object.")]
        public string? Description { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseObjectModel()
        {
            Name = string.Empty;
        }
    }
}
