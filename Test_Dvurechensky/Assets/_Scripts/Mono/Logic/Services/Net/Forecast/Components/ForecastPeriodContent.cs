/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:08:31
 * Version: 1.0.122
 */

using System;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class ForecastPeriodContent
{
    [JsonProperty("number")]
    public string Number;
    [JsonProperty("name")]
    public string Name;
    [JsonProperty("temperature")]
    public string Temperature;
    [JsonProperty("temperatureUnit")]
    public string TemperatureUnit;
    [JsonProperty("startTime")]
    public string StartTime;
    [JsonProperty("endTime")]
    public string EndTime;
    [JsonProperty("icon")]
    public string IconURL;
    [JsonIgnore]
    public Texture2D IconTexture;
}