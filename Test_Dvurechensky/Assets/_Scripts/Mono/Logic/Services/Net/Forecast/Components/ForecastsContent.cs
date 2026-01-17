/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 января 2026 11:55:40
 * Version: 1.0.149
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