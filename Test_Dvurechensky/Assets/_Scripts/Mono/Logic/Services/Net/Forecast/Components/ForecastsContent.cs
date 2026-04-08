/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 апреля 2026 14:25:30
 * Version: 1.0.230
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