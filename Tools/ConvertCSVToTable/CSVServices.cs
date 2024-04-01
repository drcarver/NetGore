using System.Globalization;

using ConvertCSVToTable.Maps;

using CsvHelper;
using CsvHelper.Configuration;

namespace ConvertCSVToTable;

internal class CSVServices
{
    internal List<TraitCSV> ReadTraitFile(string location)
    {
        try
        {
            using (var reader = new StreamReader(location))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture) 
                { 
                    HasHeaderRecord = true, 
                    Delimiter = ",", 
                    BadDataFound = null, 
                    MissingFieldFound = null 
                };
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<TraitMap>();
                    var records = csv.GetRecords<TraitCSV>().ToList();
                    return records;
                }
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

}
