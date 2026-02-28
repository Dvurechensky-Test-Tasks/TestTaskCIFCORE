/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
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