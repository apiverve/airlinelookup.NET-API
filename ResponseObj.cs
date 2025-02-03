using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("Name")]
    public string name { get; set; }

    [JsonProperty("Alias")]
    public string alias { get; set; }

    [JsonProperty("IATA")]
    public string iATA { get; set; }

    [JsonProperty("ICAO")]
    public string iCAO { get; set; }

    [JsonProperty("Callsign")]
    public string callsign { get; set; }

    [JsonProperty("Country")]
    public string country { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data[] data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
