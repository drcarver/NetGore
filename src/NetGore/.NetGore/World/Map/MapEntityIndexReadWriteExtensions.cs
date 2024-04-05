using System.Data;

using NetGore.IO;

namespace NetGore.World;

/// <summary>
/// Adds extensions to some data I/O objects for performing Read and Write operations for the MapEntityIndex.
/// All of the operations are implemented in the MapEntityIndex struct. These extensions are provided
/// purely for the convenience of accessing all the I/O operations from the same place.
/// </summary>
public static class MapEntityIndexReadWriteExtensions
{
    /// <summary>
    /// Gets the value in the <paramref name="dict"/> entry at the given <paramref name="key"/> as type MapEntityIndex.
    /// </summary>
    /// <typeparam name="T">The key Type.</typeparam>
    /// <param name="dict">The IDictionary.</param>
    /// <param name="key">The key for the value to get.</param>
    /// <returns>The value at the given <paramref name="key"/> parsed as a MapEntityIndex.</returns>
    public static MapEntityIndex AsMapEntityIndex<T>(this IDictionary<T, string> dict, T key)
    {
        return Parser.Invariant.ParseMapEntityIndex(dict[key]);
    }

    /// <summary>
    /// Tries to get the value in the <paramref name="dict"/> entry at the given <paramref name="key"/> as type MapEntityIndex.
    /// </summary>
    /// <typeparam name="T">The key Type.</typeparam>
    /// <param name="dict">The IDictionary.</param>
    /// <param name="key">The key for the value to get.</param>
    /// <param name="defaultValue">The value to use if the value at the <paramref name="key"/> could not be parsed.</param>
    /// <returns>The value at the given <paramref name="key"/> parsed as an int, or the
    /// <paramref name="defaultValue"/> if the <paramref name="key"/> did not exist in the <paramref name="dict"/>
    /// or the value at the given <paramref name="key"/> could not be parsed.</returns>
    public static MapEntityIndex AsMapEntityIndex<T>(this IDictionary<T, string> dict, T key, MapEntityIndex defaultValue)
    {
        string value;
        if (!dict.TryGetValue(key, out value))
            return defaultValue;

        MapEntityIndex parsed;
        if (!Parser.Invariant.TryParse(value, out parsed))
            return defaultValue;

        return parsed;
    }

    /// <summary>
    /// Reads the MapEntityIndex from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="r"><see cref="IDataRecord"/> to read the MapEntityIndex from.</param>
    /// <param name="i">The field index to read.</param>
    /// <returns>The MapEntityIndex read from the <see cref="IDataRecord"/>.</returns>
    public static MapEntityIndex GetMapEntityIndex(this IDataRecord r, int i)
    {
        return MapEntityIndex.Read(r, i);
    }

    /// <summary>
    /// Reads the MapEntityIndex from an <see cref="IDataRecord"/>.
    /// </summary>
    /// <param name="r"><see cref="IDataRecord"/> to read the MapEntityIndex from.</param>
    /// <param name="name">The name of the field to read the value from.</param>
    /// <returns>The MapEntityIndex read from the <see cref="IDataRecord"/>.</returns>
    public static MapEntityIndex GetMapEntityIndex(this IDataRecord r, string name)
    {
        return MapEntityIndex.Read(r, name);
    }

    /// <summary>
    /// Parses the MapEntityIndex from a string.
    /// </summary>
    /// <param name="parser">The Parser to use.</param>
    /// <param name="value">The string to parse.</param>
    /// <returns>The MapEntityIndex parsed from the string.</returns>
    public static MapEntityIndex ParseMapEntityIndex(this Parser parser, string value)
    {
        return new MapEntityIndex(parser.ParseUShort(value));
    }

    /// <summary>
    /// Reads the MapEntityIndex from a BitStream.
    /// </summary>
    /// <param name="bitStream">BitStream to read the MapEntityIndex from.</param>
    /// <returns>The MapEntityIndex read from the BitStream.</returns>
    public static MapEntityIndex ReadMapEntityIndex(this BitStream bitStream)
    {
        return MapEntityIndex.Read(bitStream);
    }

    /// <summary>
    /// Reads the MapEntityIndex from an IValueReader.
    /// </summary>
    /// <param name="valueReader">IValueReader to read the MapEntityIndex from.</param>
    /// <param name="name">The unique name of the value to read.</param>
    /// <returns>The MapEntityIndex read from the IValueReader.</returns>
    public static MapEntityIndex ReadMapEntityIndex(this IValueReader valueReader, string name)
    {
        return MapEntityIndex.Read(valueReader, name);
    }

    /// <summary>
    /// Tries to parse the MapEntityIndex from a string.
    /// </summary>
    /// <param name="parser">The Parser to use.</param>
    /// <param name="value">The string to parse.</param>
    /// <param name="outValue">If this method returns true, contains the parsed MapEntityIndex.</param>
    /// <returns>True if the parsing was successfully; otherwise false.</returns>
    public static bool TryParse(this Parser parser, string value, out MapEntityIndex outValue)
    {
        ushort tmp;
        var ret = parser.TryParse(value, out tmp);
        outValue = new MapEntityIndex(tmp);
        return ret;
    }

    /// <summary>
    /// Writes a MapEntityIndex to a BitStream.
    /// </summary>
    /// <param name="bitStream">BitStream to write to.</param>
    /// <param name="value">MapEntityIndex to write.</param>
    public static void Write(this BitStream bitStream, MapEntityIndex value)
    {
        value.Write(bitStream);
    }

    /// <summary>
    /// Writes a MapEntityIndex to a IValueWriter.
    /// </summary>
    /// <param name="valueWriter">IValueWriter to write to.</param>
    /// <param name="name">Unique name of the MapEntityIndex that will be used to distinguish it
    /// from other values when reading.</param>
    /// <param name="value">MapEntityIndex to write.</param>
    public static void Write(this IValueWriter valueWriter, string name, MapEntityIndex value)
    {
        value.Write(valueWriter, name);
    }
}