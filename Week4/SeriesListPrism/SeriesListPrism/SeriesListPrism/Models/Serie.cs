using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeriesListPrism.Models
{
    public class Serie
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("firstAired")]
        public DateTimeOffset FirstAired { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("runtime")]
        public long Runtime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("airDay")]
        public string AirDay { get; set; }

        [JsonProperty("airTime")]
        public string AirTime { get; set; }

        [JsonProperty("contentRating")]
        public string ContentRating { get; set; }

        [JsonProperty("imdbId")]
        public string ImdbId { get; set; }

        [JsonProperty("tvdbId")]
        public long TvdbId { get; set; }

        [JsonProperty("tmdbId")]
        public long TmdbId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("added")]
        public DateTimeOffset Added { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("followedByUser")]
        public bool FollowedByUser { get; set; }

        [JsonProperty("slugName")]
        public string SlugName { get; set; }
    }
}
