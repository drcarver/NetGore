using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvHelper.Configuration;

using CsvHelper;
using NetGore.Core.Models;
using ConvertCSVToTable.Maps;

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
