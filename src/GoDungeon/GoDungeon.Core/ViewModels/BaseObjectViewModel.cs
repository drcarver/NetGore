using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The base object for all models
    /// </summary>
    public partial class BaseObjectViewModel : ObservableValidator, IBaseObject
    {
        /// <summary>
        /// The Id for the object
        /// </summary>
        [Description("Primary key of the object.")]
        [ObservableProperty]
        private Guid? id;

        /// <summary>
        /// The name of the object
        /// </summary>
        [MaxLength(80)]
        [MinLength(4)]
        [Description("The Name of the object.")]
        [ObservableProperty]
        private string? name;

        /// <summary>
        /// The Description of the object
        /// </summary>
        [Description("The Description of the object.")]
        [ObservableProperty]
        private string? description;

        /// <summary>
        /// Constructor
        /// </summary>
        public BaseObjectViewModel()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }
    }
}
