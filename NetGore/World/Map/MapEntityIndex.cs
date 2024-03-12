using System.ComponentModel;
using System.Data;

using NetGore.IO;

namespace NetGore.World;

/// <summary>
/// Represents the integral value of the index of a <see cref="DynamicEntity"/> in respect to the
/// <see cref="IMap"/> it is on. For a single <see cref="IMap"/>, this will contain the same value for
/// a <see cref="DynamicEntity"/> on both the server and client, making it a suitable property to use
/// to reference a <see cref="DynamicEntity"/> between the client and server. Non-dynamic entities do not
/// contain a <see cref="MapEntityIndex"/>.
/// </summary>
[Serializable]
[TypeConverter(typeof(MapEntityIndexTypeConverter))]
public struct MapEntityIndex : IComparable<MapEntityIndex>, IConvertible, IFormattable, IComparable<int>, IEquatable<int>
{
    /// <summary>
    /// Represents the largest possible value of MapEntityIndex. This field is constant.
    /// </summary>
    public const int MaxValue = ushort.MaxValue;

    /// <summary>
    /// Represents the smallest possible value of MapEntityIndex. This field is constant.
    /// </summary>
    public const int MinValue = ushort.MinValue;

    /// <summary>
    /// The underlying value. This contains the actual value of the struct instance.
    /// </summary>
    readonly ushort _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="MapEntityIndex"/> struct.
    /// </summary>
    /// <param name="value">Value to assign to the new MapEntityIndex.</param>
    /// <exception cref="ArgumentOutOfRangeException"><c>value</c> is out of range.</exception>
    public MapEntityIndex(int value)
    {
        if (value < MinValue || value > MaxValue)
            throw new ArgumentOutOfRangeException("value");

        _value = (ushort)value;
    }

    /// <summary>
    /// Indicates whether this instance and a specified object are equal.
    /// </summary>
    /// <param name="other">Another object to compare to.</param>
    /// <returns>
    /// True if <paramref name="other"/> and this instance are the same type and represent the same value; otherwise, false.
    /// </returns>
    public bool Equals(MapEntityIndex other)
    {
        return other._value == _value;
    }

    /// <summary>
    /// Indicates whether this instance and a specified object are equal.
    /// </summary>
    /// <param name="obj">Another object to compare to.</param>
    /// <returns>
    /// True if <paramref name="obj"/> and this instance are the same type and represent the same value; otherwise, false.
    /// </returns>
    public override readonly bool Equals(object obj) => obj is MapEntityIndex && this == (MapEntityIndex)obj;

    /// <summary>
    /// Returns the hash code for this instance.
    /// </summary>
    /// <returns>
    /// A 32-bit signed integer that is the hash code for this instance.
    /// </returns>
    public override readonly int GetHashCode() => _value.GetHashCode();

    /// <summary>
    /// Gets the raw internal value of this MapEntityIndex.
    /// </summary>
    /// <returns>The raw internal value.</returns>
    public readonly ushort GetRawValue() => _value;

    /// <summary>
    /// Reads an MapEntityIndex from an IValueReader.
    /// </summary>
    /// <param name="reader">IValueReader to read from.</param>
    /// <param name="name">Unique name of the value to read.</param>
    /// <returns>The MapEntityIndex read from the IValueReader.</returns>
    public static MapEntityIndex Read(IValueReader reader, string name)
    {
        var value = reader.ReadUShort(name);
        return new MapEntityIndex(value);
    }

    /// <summary>
    /// Reads an MapEntityIndex from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="reader"><see cref="IDataRecord"/> to get the value from.</param>
    /// <param name="i">The index of the field to find.</param>
    /// <returns>The MapEntityIndex read from the <see cref="IDataRecord"/>.</returns>
    public static MapEntityIndex Read(IDataRecord reader, int i)
    {
        var value = reader.GetValue(i);
        if (value is ushort)
            return new MapEntityIndex((ushort)value);

        var convertedValue = Convert.ToUInt16(value);
        return new MapEntityIndex(convertedValue);
    }

    /// <summary>
    /// Reads an MapEntityIndex from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="reader"><see cref="IDataRecord"/> to get the value from.</param>
    /// <param name="name">The name of the field to find.</param>
    /// <returns>The MapEntityIndex read from the <see cref="IDataRecord"/>.</returns>
    public static MapEntityIndex Read(IDataRecord reader, string name) => Read(reader, reader.GetOrdinal(name));

    /// <summary>
    /// Reads an MapEntityIndex from an IValueReader.
    /// </summary>
    /// <param name="bitStream">BitStream to read from.</param>
    /// <returns>The MapEntityIndex read from the BitStream.</returns>
    public static MapEntityIndex Read(BitStream bitStream)
    {
        var value = bitStream.ReadUShort();
        return new MapEntityIndex(value);
    }

    /// <summary>
    /// Converts the numeric value of this instance to its equivalent string representation.
    /// </summary>
    /// <returns>The string representation of the value of this instance, consisting of a sequence
    /// of digits ranging from 0 to 9, without leading zeroes.</returns>
    public override readonly string ToString() => _value.ToString();

    /// <summary>
    /// Writes the MapEntityIndex to an IValueWriter.
    /// </summary>
    /// <param name="writer">IValueWriter to write to.</param>
    /// <param name="name">Unique name of the MapEntityIndex that will be used to distinguish it
    /// from other values when reading.</param>
    public readonly void Write(IValueWriter writer, string name) => writer.Write(name, _value);

    /// <summary>
    /// Writes the MapEntityIndex to an IValueWriter.
    /// </summary>
    /// <param name="bitStream">BitStream to write to.</param>
    public readonly void Write(BitStream bitStream) => bitStream.Write(_value);

    #region IComparable<int> Members

    /// <summary>
    /// Compares the current object with another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// A 32-bit signed integer that indicates the relative order of the objects being compared. The return value has the following meanings: 
    ///                     Value 
    ///                     Meaning 
    ///                     Less than zero 
    ///                     This object is less than the <paramref name="other"/> parameter.
    ///                     Zero 
    ///                     This object is equal to <paramref name="other"/>. 
    ///                     Greater than zero 
    ///                     This object is greater than <paramref name="other"/>. 
    /// </returns>
    public readonly int CompareTo(int other) => _value.CompareTo(other);

    #endregion

    #region IComparable<MapEntityIndex> Members

    /// <summary>
    /// Compares the current object with another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// A 32-bit signed integer that indicates the relative order of the objects being compared.
    /// The return value has the following meanings: 
    ///                     Value 
    ///                     Meaning 
    ///                     Less than zero 
    ///                     This object is less than the <paramref name="other"/> parameter.
    ///                     Zero 
    ///                     This object is equal to <paramref name="other"/>. 
    ///                     Greater than zero 
    ///                     This object is greater than <paramref name="other"/>. 
    /// </returns>
    public readonly int CompareTo(MapEntityIndex other) => _value.CompareTo(other._value);

    #endregion

    #region IConvertible Members

    /// <summary>
    /// Returns the <see cref="T:System.TypeCode"/> for this instance.
    /// </summary>
    /// <returns>
    /// The enumerated constant that is the <see cref="T:System.TypeCode"/> of the class or value type that implements this interface.
    /// </returns>
    public readonly TypeCode GetTypeCode() => _value.GetTypeCode();

    /// <summary>
    /// Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation
    /// that supplies culture-specific formatting information.</param>
    /// <returns>
    /// A Boolean value equivalent to the value of this instance.
    /// </returns>
    readonly bool IConvertible.ToBoolean(IFormatProvider provider) => ((IConvertible)_value).ToBoolean(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 8-bit unsigned integer equivalent to the value of this instance.
    /// </returns>
    readonly byte IConvertible.ToByte(IFormatProvider provider) => ((IConvertible)_value).ToByte(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A Unicode character equivalent to the value of this instance.
    /// </returns>
    readonly char IConvertible.ToChar(IFormatProvider provider) => ((IConvertible)_value).ToChar(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent <see cref="T:System.DateTime"/> using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A <see cref="T:System.DateTime"/> instance equivalent to the value of this instance.
    /// </returns>
    readonly DateTime IConvertible.ToDateTime(IFormatProvider provider) => ((IConvertible)_value).ToDateTime(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent <see cref="T:System.Decimal"/> number using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information. </param>
    /// <returns>
    /// A <see cref="T:System.Decimal"/> number equivalent to the value of this instance.
    /// </returns>
    readonly decimal IConvertible.ToDecimal(IFormatProvider provider) => ((IConvertible)_value).ToDecimal(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A double-precision floating-point number equivalent to the value of this instance.
    /// </returns>
    readonly double IConvertible.ToDouble(IFormatProvider provider) => ((IConvertible)_value).ToDouble(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 16-bit signed integer equivalent to the value of this instance.
    /// </returns>
    readonly short IConvertible.ToInt16(IFormatProvider provider) => ((IConvertible)_value).ToInt16(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 32-bit signed integer equivalent to the value of this instance.
    /// </returns>
    readonly int IConvertible.ToInt32(IFormatProvider provider) => ((IConvertible)_value).ToInt32(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 64-bit signed integer equivalent to the value of this instance.
    /// </returns>
    readonly long IConvertible.ToInt64(IFormatProvider provider) => ((IConvertible)_value).ToInt64(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 8-bit signed integer equivalent to the value of this instance.
    /// </returns>
    readonly sbyte IConvertible.ToSByte(IFormatProvider provider) => ((IConvertible)_value).ToSByte(provider);

    /// <summary>
    /// Converts the value of this instance to an equivalent single-precision floating-point number using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information. </param>
    /// <returns>
    /// A single-precision floating-point number equivalent to the value of this instance.
    /// </returns>
    float IConvertible.ToSingle(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToSingle(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent <see cref="T:System.String"/> using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A <see cref="T:System.String"/> instance equivalent to the value of this instance.
    /// </returns>
    public string ToString(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToString(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an <see cref="T:System.Object"/> of the specified <see cref="T:System.Type"/> that has an equivalent value, using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="conversionType">The <see cref="T:System.Type"/> to which the value of this instance is converted.</param>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An <see cref="T:System.Object"/> instance of type <paramref name="conversionType"/> whose value is equivalent to the value of this instance.
    /// </returns>
    object IConvertible.ToType(Type conversionType, IFormatProvider provider)
    {
        return ((IConvertible)_value).ToType(conversionType, provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 16-bit unsigned integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 16-bit unsigned integer equivalent to the value of this instance.
    /// </returns>
    ushort IConvertible.ToUInt16(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToUInt16(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 32-bit unsigned integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 32-bit unsigned integer equivalent to the value of this instance.
    /// </returns>
    uint IConvertible.ToUInt32(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToUInt32(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 64-bit unsigned integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 64-bit unsigned integer equivalent to the value of this instance.
    /// </returns>
    ulong IConvertible.ToUInt64(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToUInt64(provider);
    }

    #endregion

    #region IEquatable<int> Members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
    /// </returns>
    public readonly bool Equals(int other) => _value.Equals(other);

    #endregion

    #region IFormattable Members

    /// <summary>
    /// Formats the value of the current instance using the specified format.
    /// </summary>
    /// <param name="format">The <see cref="T:System.String"/> specifying the format to use.
    ///                     -or- 
    ///                 null to use the default format defined for the type of the <see cref="T:System.IFormattable"/> implementation. 
    /// </param>
    /// <param name="formatProvider">The <see cref="T:System.IFormatProvider"/> to use to format the value.
    ///                     -or- 
    ///                 null to obtain the numeric format information from the current locale setting of the operating system. 
    /// </param>
    /// <returns>
    /// A <see cref="T:System.String"/> containing the value of the current instance in the specified format.
    /// </returns>
    public readonly string ToString(string format, IFormatProvider formatProvider) => _value.ToString(format, formatProvider);

    #endregion

    /// <summary>
    /// Implements operator ++.
    /// </summary>
    /// <param name="l">The MapEntityIndex to increment.</param>
    /// <returns>The incremented MapEntityIndex.</returns>
    public static MapEntityIndex operator ++(MapEntityIndex l) => new MapEntityIndex(l._value + 1);

    /// <summary>
    /// Implements operator --.
    /// </summary>
    /// <param name="l">The MapEntityIndex to decrement.</param>
    /// <returns>The decremented MapEntityIndex.</returns>
    public static MapEntityIndex operator --(MapEntityIndex l) => new MapEntityIndex(l._value - 1);

    /// <summary>
    /// Implements operator +.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>Result of the left side plus the right side.</returns>
    public static MapEntityIndex operator +(MapEntityIndex left, MapEntityIndex right) => new MapEntityIndex(left._value + right._value);

    /// <summary>
    /// Implements operator -.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>Result of the left side minus the right side.</returns>
    public static MapEntityIndex operator -(MapEntityIndex left, MapEntityIndex right) => new MapEntityIndex(left._value - right._value);

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(MapEntityIndex left, int right) => left._value == right;

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(MapEntityIndex left, int right) => left._value != right;

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(int left, MapEntityIndex right) => left == right._value;

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(int left, MapEntityIndex right) => left != right._value;

    /// <summary>
    /// Casts a MapEntityIndex to an Int32.
    /// </summary>
    /// <param name="MapEntityIndex">MapEntityIndex to cast.</param>
    /// <returns>The Int32.</returns>
    public static explicit operator int(MapEntityIndex MapEntityIndex) => MapEntityIndex._value;

    /// <summary>
    /// Casts an Int32 to a MapEntityIndex.
    /// </summary>
    /// <param name="value">Int32 to cast.</param>
    /// <returns>The MapEntityIndex.</returns>
    public static explicit operator MapEntityIndex(int value) => new MapEntityIndex(value);

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(int left, MapEntityIndex right) => left > right._value;

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(int left, MapEntityIndex right) => left < right._value;

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(MapEntityIndex left, MapEntityIndex right) => left._value > right._value;

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(MapEntityIndex left, MapEntityIndex right) => left._value < right._value;

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(MapEntityIndex left, int right) => left._value > right;

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(MapEntityIndex left, int right) => left._value < right;

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(int left, MapEntityIndex right) => left >= right._value;

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(int left, MapEntityIndex right) => left <= right._value;

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(MapEntityIndex left, int right) => left._value >= right;

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(MapEntityIndex left, int right) => left._value <= right;

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(MapEntityIndex left, MapEntityIndex right) => left._value >= right._value;

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(MapEntityIndex left, MapEntityIndex right) => left._value <= right._value;

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(MapEntityIndex left, MapEntityIndex right) => left._value != right._value;

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(MapEntityIndex left, MapEntityIndex right) => left._value == right._value;
}
