/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:19:05
 * Version: 1.0.221
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