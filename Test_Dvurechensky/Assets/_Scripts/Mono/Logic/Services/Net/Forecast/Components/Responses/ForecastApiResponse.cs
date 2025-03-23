using System;
using Newtonsoft.Json;

[Serializable]
public class ForecastApiResponse
{
    [JsonProperty("properties")]
    public ForecastsContent Properties;
}