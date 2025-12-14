/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:32:37
 * Version: 1.0.115
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