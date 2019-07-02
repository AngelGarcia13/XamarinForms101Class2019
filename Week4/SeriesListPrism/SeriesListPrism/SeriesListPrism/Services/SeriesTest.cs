using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SeriesListPrism.Models;

namespace SeriesListPrism.Services
{
    public class SeriesTest : ISeriesService
    {
        public Task<IEnumerable<Serie>> GetAllSeriesAsync()
        {
            return null;
        }
    }
}
