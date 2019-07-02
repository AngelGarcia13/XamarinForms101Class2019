using Newtonsoft.Json;
using SeriesListPrism.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SeriesListPrism.Services
{
    public class SeriesService : ISeriesService
    {
        public async Task<IEnumerable<Serie>> GetAllSeriesAsync()
        {
            var result = new List<Serie>();
            try
            {
                using (var client = new HttpClient())
                {
                    var stringResponse = await client
                        .GetStringAsync("https://api.trackseries.tv/v1/Stats/TopSeries/");
                    result = JsonConvert.DeserializeObject<List<Serie>>(stringResponse);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
            }

            return result;
        }
    }
}
