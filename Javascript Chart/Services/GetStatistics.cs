using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ChartJS.Models;

namespace ChartJS.Services
{
    public class GetStatistics
    {
        public async Task<List<VehicleSales>> GetMonthlySales()
        {
            var filePath = (@"..\ChartJS\VehicleSales2020.json");
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000]; // This specifies an array length of hexadecimal 1000 = 4096
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.UTF8.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                var data = JsonConvert.DeserializeObject<Dictionary<string, List<VehicleSales>>>(sb.ToString());
                List<VehicleSales> vehSales = new List<VehicleSales>();
                foreach (KeyValuePair<string, List<VehicleSales>> kvp in data)
                {
                    foreach (var item in kvp.Value)
                    {
                        vehSales.Add(item);
                    }
                }
                return vehSales;
            }
        }
    }
}
