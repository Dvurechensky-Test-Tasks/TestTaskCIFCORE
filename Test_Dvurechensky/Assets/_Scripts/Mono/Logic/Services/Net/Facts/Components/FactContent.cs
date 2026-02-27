/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class FactContent
{
    [JsonIgnore]
    public int Number;
    [JsonProperty("id")]
    public string Id;
    [JsonProperty("type")]
    public string Type;
    [JsonProperty("attributes")]
    public FactAttributes Attributes;
}