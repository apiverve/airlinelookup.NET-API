using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Alias")]
        public string Alias { get; set; }

        [JsonProperty("IATA")]
        public string IATA { get; set; }

        [JsonProperty("ICAO")]
        public string ICAO { get; set; }

        [JsonProperty("Callsign")]
        public string Callsign { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data[] Data { get; set; }

    }
}
