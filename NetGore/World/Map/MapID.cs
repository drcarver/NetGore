using System.ComponentModel;
using System.Data;

using NetGore.IO;

namespace NetGore.World;

/// <summary>
/// Represents the ID of a Map.
/// </summary>
[Serializable]
[TypeConverter(typeof(MapIDTypeConverter))]
public struct MapID : IComparable<MapID>, IConvertible, IFormattable, IComparable<int>, IEquatable<int>
{
    /// <summary>
    /// Represents the largest possible value of MapID. This field is constant.
    /// </summary>
    public const int MaxValue = ushort.MaxValue;

    /// <summary>
    /// Represents the smallest possible value of MapID. This field is constant.
    /// </summary>
    public const int MinValue = ushort.MinValue;

    /// <summary>
    /// The underlying value. This contains the actual value of the struct instance.
    /// </summary>
    readonly ushort _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="MapID"/> struct.
    /// </summary>
    /// <param name="value">Value to assign to the new <see cref="MapID"/>.</param>
    /// <exception cref="ArgumentOutOfRangeException"><c>value</c> is out of range.</exception>
    public MapID(int value)
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
    public bool Equals(MapID other)
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
    public override bool Equals(object obj)
    {
        return obj is MapID && this == (MapID)obj;
    }

    /// <summary>
    /// Returns the hash code for this instance.
    /// </summary>
    /// <returns>
    /// A 32-bit signed integer that is the hash code for this instance.
    /// </returns>
    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    /// <summary>
    /// Gets the raw internal value of this MapID.
    /// </summary>
    /// <returns>The raw internal value.</returns>
    public ushort GetRawValue()
    {
        return _value;
    }

    /// <summary>
    /// Reads an MapID from an IValueReader.
    /// </summary>
    /// <param name="reader">IValueReader to read from.</param>
    /// <param name="name">Unique name of the value to read.</param>
    /// <returns>The MapID read from the IValueReader.</returns>
    public static MapID Read(IValueReader reader, string name)
    {
        var value = reader.ReadUShort(name);
        return new MapID(value);
    }

    /// <summary>
    /// Reads an MapID from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="reader"><see cref="IDataRecord"/> to get the value from.</param>
    /// <param name="i">The index of the field to find.</param>
    /// <returns>The MapID read from the <see cref="IDataRecord"/>.</returns>
    public static MapID Read(IDataRecord reader, int i)
    {
        var value = reader.GetValue(i);
        if (value is ushort)
            return new MapID((ushort)value);

        var convertedValue = Convert.ToUInt16(value);
        return new MapID(convertedValue);
    }

    /// <summary>
    /// Reads an MapID from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="reader"><see cref="IDataRecord"/> to get the value from.</param>
    /// <param name="name">The name of the field to find.</param>
    /// <returns>The MapID read from the <see cref="IDataRecord"/>.</returns>
    public static MapID Read(IDataRecord reader, string name)
    {
        return Read(reader, reader.GetOrdinal(name));
    }

    /// <summary>
    /// Reads an MapID from an IValueReader.
    /// </summary>
    /// <param name="bitStream">BitStream to read from.</param>
    /// <returns>The MapID read from the BitStream.</returns>
    public static MapID Read(BitStream bitStream)
    {
        var value = bitStream.ReadUShort();
        return new MapID(value);
    }

    /// <summary>
    /// Converts the numeric value of this instance to its equivalent string representation.
    /// </summary>
    /// <returns>The string representation of the value of this instance, consisting of a sequence
    /// of digits ranging from 0 to 9, without leading zeroes.</returns>
    public override string ToString()
    {
        return _value.ToString();
    }

    /// <summary>
    /// Writes the MapID to an IValueWriter.
    /// </summary>
    /// <param name="writer">IValueWriter to write to.</param>
    /// <param name="name">Unique name of the MapID that will be used to distinguish it
    /// from other values when reading.</param>
    public void Write(IValueWriter writer, string name)
    {
        writer.Write(name, _value);
    }

    /// <summary>
    /// Writes the MapID to an IValueWriter.
    /// </summary>
    /// <param name="bitStream">BitStream to write to.</param>
    public void Write(BitStream bitStream)
    {
        bitStream.Write(_value);
    }

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
    public int CompareTo(int other)
    {
        return _value.CompareTo(other);
    }

    #endregion

    #region IComparable<MapID> Members

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
    public int CompareTo(MapID other)
    {
        return _value.CompareTo(other._value);
    }

    #endregion

    #region IConvertible Members

    /// <summary>
    /// Returns the <see cref="T:System.TypeCode"/> for this instance.
    /// </summary>
    /// <returns>
    /// The enumerated constant that is the <see cref="T:System.TypeCode"/> of the class or value type that implements this interface.
    /// </returns>
    public TypeCode GetTypeCode()
    {
        return _value.GetTypeCode();
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent Boolean value using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation
    /// that supplies culture-specific formatting information.</param>
    /// <returns>
    /// A Boolean value equivalent to the value of this instance.
    /// </returns>
    bool IConvertible.ToBoolean(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToBoolean(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 8-bit unsigned integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 8-bit unsigned integer equivalent to the value of this instance.
    /// </returns>
    byte IConvertible.ToByte(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToByte(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent Unicode character using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A Unicode character equivalent to the value of this instance.
    /// </returns>
    char IConvertible.ToChar(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToChar(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent <see cref="T:System.DateTime"/> using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A <see cref="T:System.DateTime"/> instance equivalent to the value of this instance.
    /// </returns>
    DateTime IConvertible.ToDateTime(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToDateTime(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent <see cref="T:System.Decimal"/> number using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information. </param>
    /// <returns>
    /// A <see cref="T:System.Decimal"/> number equivalent to the value of this instance.
    /// </returns>
    decimal IConvertible.ToDecimal(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToDecimal(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent double-precision floating-point number using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// A double-precision floating-point number equivalent to the value of this instance.
    /// </returns>
    double IConvertible.ToDouble(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToDouble(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 16-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 16-bit signed integer equivalent to the value of this instance.
    /// </returns>
    short IConvertible.ToInt16(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToInt16(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 32-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 32-bit signed integer equivalent to the value of this instance.
    /// </returns>
    int IConvertible.ToInt32(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToInt32(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 64-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 64-bit signed integer equivalent to the value of this instance.
    /// </returns>
    long IConvertible.ToInt64(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToInt64(provider);
    }

    /// <summary>
    /// Converts the value of this instance to an equivalent 8-bit signed integer using the specified culture-specific formatting information.
    /// </summary>
    /// <param name="provider">An <see cref="T:System.IFormatProvider"/> interface implementation that supplies
    /// culture-specific formatting information.</param>
    /// <returns>
    /// An 8-bit signed integer equivalent to the value of this instance.
    /// </returns>
    sbyte IConvertible.ToSByte(IFormatProvider provider)
    {
        return ((IConvertible)_value).ToSByte(provider);
    }

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
    public bool Equals(int other)
    {
        return _value.Equals(other);
    }

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
    public string ToString(string format, IFormatProvider formatProvider)
    {
        return _value.ToString(format, formatProvider);
    }

    #endregion

    /// <summary>
    /// Implements operator ++.
    /// </summary>
    /// <param name="l">The MapID to increment.</param>
    /// <returns>The incremented MapID.</returns>
    public static MapID operator ++(MapID l)
    {
        return new MapID(l._value + 1);
    }

    /// <summary>
    /// Implements operator --.
    /// </summary>
    /// <param name="l">The MapID to decrement.</param>
    /// <returns>The decremented MapID.</returns>
    public static MapID operator --(MapID l)
    {
        return new MapID(l._value - 1);
    }

    /// <summary>
    /// Implements operator +.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>Result of the left side plus the right side.</returns>
    public static MapID operator +(MapID left, MapID right)
    {
        return new MapID(left._value + right._value);
    }

    /// <summary>
    /// Implements operator -.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>Result of the left side minus the right side.</returns>
    public static MapID operator -(MapID left, MapID right)
    {
        return new MapID(left._value - right._value);
    }

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(MapID left, int right)
    {
        return left._value == right;
    }

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(MapID left, int right)
    {
        return left._value != right;
    }

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(int left, MapID right)
    {
        return left == right._value;
    }

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(int left, MapID right)
    {
        return left != right._value;
    }

    /// <summary>
    /// Casts a MapID to an Int32.
    /// </summary>
    /// <param name="MapID">MapID to cast.</param>
    /// <returns>The Int32.</returns>
    public static explicit operator int(MapID MapID)
    {
        return MapID._value;
    }

    /// <summary>
    /// Casts an Int32 to a MapID.
    /// </summary>
    /// <param name="value">Int32 to cast.</param>
    /// <returns>The MapID.</returns>
    public static explicit operator MapID(int value)
    {
        return new MapID(value);
    }

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(int left, MapID right)
    {
        return left > right._value;
    }

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(int left, MapID right)
    {
        return left < right._value;
    }

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(MapID left, MapID right)
    {
        return left._value > right._value;
    }

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(MapID left, MapID right)
    {
        return left._value < right._value;
    }

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than the right.</returns>
    public static bool operator >(MapID left, int right)
    {
        return left._value > right;
    }

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than the left.</returns>
    public static bool operator <(MapID left, int right)
    {
        return left._value < right;
    }

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(int left, MapID right)
    {
        return left >= right._value;
    }

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(int left, MapID right)
    {
        return left <= right._value;
    }

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(MapID left, int right)
    {
        return left._value >= right;
    }

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(MapID left, int right)
    {
        return left._value <= right;
    }

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the left argument is greater than or equal to the right.</returns>
    public static bool operator >=(MapID left, MapID right)
    {
        return left._value >= right._value;
    }

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the right argument is greater than or equal to the left.</returns>
    public static bool operator <=(MapID left, MapID right)
    {
        return left._value <= right._value;
    }

    /// <summary>
    /// Implements operator !=.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are not equal.</returns>
    public static bool operator !=(MapID left, MapID right)
    {
        return left._value != right._value;
    }

    /// <summary>
    /// Implements operator ==.
    /// </summary>
    /// <param name="left">Left side argument.</param>
    /// <param name="right">Right side argument.</param>
    /// <returns>If the two arguments are equal.</returns>
    public static bool operator ==(MapID left, MapID right)
    {
        return left._value == right._value;
    }
}

/// <summary>
/// Adds extensions to some data I/O objects for performing Read and Write operations for the MapID.
/// All of the operations are implemented in the MapID struct. These extensions are provided
/// purely for the convenience of accessing all the I/O operations from the same place.
/// </summary>
public static class MapIDReadWriteExtensions
{
    /// <summary>
    /// Gets the value in the <paramref name="dict"/> entry at the given <paramref name="key"/> as type MapID.
    /// </summary>
    /// <typeparam name="T">The key Type.</typeparam>
    /// <param name="dict">The IDictionary.</param>
    /// <param name="key">The key for the value to get.</param>
    /// <returns>The value at the given <paramref name="key"/> parsed as a MapID.</returns>
    public static MapID AsMapID<T>(this IDictionary<T, string> dict, T key)
    {
        return Parser.Invariant.ParseMapID(dict[key]);
    }

    /// <summary>
    /// Tries to get the value in the <paramref name="dict"/> entry at the given <paramref name="key"/> as type MapID.
    /// </summary>
    /// <typeparam name="T">The key Type.</typeparam>
    /// <param name="dict">The IDictionary.</param>
    /// <param name="key">The key for the value to get.</param>
    /// <param name="defaultValue">The value to use if the value at the <paramref name="key"/> could not be parsed.</param>
    /// <returns>The value at the given <paramref name="key"/> parsed as an int, or the
    /// <paramref name="defaultValue"/> if the <paramref name="key"/> did not exist in the <paramref name="dict"/>
    /// or the value at the given <paramref name="key"/> could not be parsed.</returns>
    public static MapID AsMapID<T>(this IDictionary<T, string> dict, T key, MapID defaultValue)
    {
        string value;
        if (!dict.TryGetValue(key, out value))
            return defaultValue;

        MapID parsed;
        if (!Parser.Invariant.TryParse(value, out parsed))
            return defaultValue;

        return parsed;
    }

    /// <summary>
    /// Reads the MapID from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="r"><see cref="IDataRecord"/> to read the MapID from.</param>
    /// <param name="i">The field index to read.</param>
    /// <returns>The MapID read from the <see cref="IDataRecord"/>.</returns>
    public static MapID GetMapID(this IDataRecord r, int i)
    {
        return MapID.Read(r, i);
    }

    /// <summary>
    /// Reads the MapID from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="r"><see cref="IDataRecord"/> to read the MapID from.</param>
    /// <param name="name">The name of the field to read the value from.</param>
    /// <returns>The MapID read from the <see cref="IDataRecord"/>.</returns>
    public static MapID GetMapID(this IDataRecord r, string name)
    {
        return MapID.Read(r, name);
    }

    /// <summary>
    /// Parses the MapID from a string.
    /// </summary>
    /// <param name="parser">The Parser to use.</param>
    /// <param name="value">The string to parse.</param>
    /// <returns>The MapID parsed from the string.</returns>
    public static MapID ParseMapID(this Parser parser, string value)
    {
        return new MapID(parser.ParseUShort(value));
    }

    /// <summary>
    /// Reads the MapID from a BitStream.
    /// </summary>
    /// <param name="bitStream">BitStream to read the MapID from.</param>
    /// <returns>The MapID read from the BitStream.</returns>
    public static MapID ReadMapID(this BitStream bitStream)
    {
        return MapID.Read(bitStream);
    }

    /// <summary>
    /// Reads the MapID from an IValueReader.
    /// </summary>
    /// <param name="valueReader">IValueReader to read the MapID from.</param>
    /// <param name="name">The unique name of the value to read.</param>
    /// <returns>The MapID read from the IValueReader.</returns>
    public static MapID ReadMapID(this IValueReader valueReader, string name)
    {
        return MapID.Read(valueReader, name);
    }

    /// <summary>
    /// Tries to parse the MapID from a string.
    /// </summary>
    /// <param name="parser">The Parser to use.</param>
    /// <param name="value">The string to parse.</param>
    /// <param name="outValue">If this method returns true, contains the parsed MapID.</param>
    /// <returns>True if the parsing was successfully; otherwise false.</returns>
    public static bool TryParse(this Parser parser, string value, out MapID outValue)
    {
        ushort tmp;
        var ret = parser.TryParse(value, out tmp);
        outValue = new MapID(tmp);
        return ret;
    }

    /// <summary>
    /// Writes a MapID to a BitStream.
    /// </summary>
    /// <param name="bitStream">BitStream to write to.</param>
    /// <param name="value">MapID to write.</param>
    public static void Write(this BitStream bitStream, MapID value)
    {
        value.Write(bitStream);
    }

    /// <summary>
    /// Writes a MapID to a IValueWriter.
    /// </summary>
    /// <param name="valueWriter">IValueWriter to write to.</param>
    /// <param name="name">Unique name of the MapID that will be used to distinguish it
    /// from other values when reading.</param>
    /// <param name="value">MapID to write.</param>
    public static void Write(this IValueWriter valueWriter, string name, MapID value)
    {
        value.Write(valueWriter, name);
    }
}