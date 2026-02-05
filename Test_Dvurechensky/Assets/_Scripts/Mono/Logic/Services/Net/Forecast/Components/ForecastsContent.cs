/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
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