using System;
using System.ComponentModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The base object for all data models
    /// </summary>
    public partial class DataObjectViewModel : BaseObjectViewModel, IDataObject
    {
        /// <summary>
        /// Is the object marked for deletion?
        /// </summary>
        [Description("Is the object marked for deletion?")]
        [ObservableProperty]
        private bool isDeleted;

        /// <summary>
        /// Date and Time the object was created
        /// </summary>
        [Description("Date and Time the object was created")]
        [ObservableProperty]
        private DateTime createdAt;

        /// <summary>
        /// Date and Time the object was last updated
        /// </summary>
        [Description("Date and Time the object was last updated")]
        [ObservableProperty]
        private DateTime updatedAt;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataObjectViewModel()
        {
            UpdatedAt = DateTime.UtcNow;
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }
    }
}
