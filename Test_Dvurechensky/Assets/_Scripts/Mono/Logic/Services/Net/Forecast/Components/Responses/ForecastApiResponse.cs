/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 февраля 2026 13:11:53
 * Version: 1.0.183
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class ForecastApiResponse
{
    [JsonProperty("properties")]
    public ForecastsContent Properties;
}