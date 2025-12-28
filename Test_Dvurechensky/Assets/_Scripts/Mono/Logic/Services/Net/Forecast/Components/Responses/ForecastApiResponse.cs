/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 декабря 2025 06:50:28
 * Version: 1.0.129
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class ForecastApiResponse
{
    [JsonProperty("properties")]
    public ForecastsContent Properties;
}