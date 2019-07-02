using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesListPrism.Models
{
    public partial class Genre
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
