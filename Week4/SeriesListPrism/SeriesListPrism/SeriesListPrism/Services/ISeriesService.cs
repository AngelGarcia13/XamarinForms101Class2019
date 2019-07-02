using SeriesListPrism.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeriesListPrism.Services
{
    public interface ISeriesService
    {
        Task<IEnumerable<Serie>> GetAllSeriesAsync();
    }
}
