/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 декабря 2025 09:27:48
 * Version: 1.0.125
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class ForecastApiResponse
{
    [JsonProperty("properties")]
    public ForecastsContent Properties;
}