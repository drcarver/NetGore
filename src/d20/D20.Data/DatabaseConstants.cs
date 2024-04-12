using Microsoft.Maui.Storage;

namespace NetGore.Models;

public class DatabaseConstants
{
    public const string DatabaseFilename = "NetGoreDB.db";

    public static string DatabasePath =>
        Path.Combine(FileSystem.Current.AppDataDirectory, DatabaseFilename);
}
