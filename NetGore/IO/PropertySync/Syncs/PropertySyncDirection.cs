﻿using System.Linq;

using NetGore.Core.Enum;
using NetGore.IO;
using NetGore.IO.PropertySync;

namespace NetGore.IO.PropertySync
{
    /// <summary>
    /// Implementation of a <see cref="PropertySyncBase{T}"/> that handles synchronizing a Direction.
    /// </summary>
    [PropertySyncHandler(typeof(Direction))]
    public sealed class PropertySyncWeaponType : PropertySyncBase<Direction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertySyncWeaponType"/> class.
        /// </summary>
        /// <param name="syncValueAttributeInfo">The <see cref="SyncValueAttributeInfo"/>.</param>
        public PropertySyncWeaponType(SyncValueAttributeInfo syncValueAttributeInfo)
            : base(syncValueAttributeInfo)
        {
        }

        /// <summary>
        /// When overridden in the derived class, reads a value with the specified name from an IValueReader.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <param name="reader">IValueReader to read from.</param>
        /// <returns>Value read from the IValueReader.</returns>
        protected override Direction Read(string name, IValueReader reader)
        {
            return reader.ReadEnum<Direction>(name);
        }

        /// <summary>
        /// When overridden in the derived class, writes a value to an IValueWriter with the specified name.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <param name="writer">IValueWriter to write to.</param>
        /// <param name="value">Value to write.</param>
        protected override void Write(string name, IValueWriter writer, Direction value)
        {
            writer.WriteEnum(name, value);
        }
    }
}