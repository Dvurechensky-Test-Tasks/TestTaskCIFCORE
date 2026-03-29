/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 марта 2026 11:11:52
 * Version: 1.0.220
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class ForecastsContent
{
    [JsonProperty("units")]
    public string Units;
    [JsonProperty("periods")]
    public List<ForecastPeriodContent> Periods;

    public bool IsValidData => Periods != null && !string.IsNullOrEmpty(Units);
}