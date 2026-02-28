/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
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