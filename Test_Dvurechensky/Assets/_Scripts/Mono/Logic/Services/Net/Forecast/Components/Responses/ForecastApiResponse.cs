/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class ForecastApiResponse
{
    [JsonProperty("properties")]
    public ForecastsContent Properties;
}