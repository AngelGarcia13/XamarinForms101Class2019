using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesListPrism.Models
{
    public partial class Images
    {
        [JsonProperty("poster")]
        public Uri Poster { get; set; }

        [JsonProperty("fanart")]
        public Uri Fanart { get; set; }

        [JsonProperty("banner")]
        public Uri Banner { get; set; }
    }
}
