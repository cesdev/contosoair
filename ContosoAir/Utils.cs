using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContosoAir
{
    public class Utils
    {
        public static T loadData<T>(string path)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var jsonString = System.IO.File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(jsonString, options);

        }
    }
}
