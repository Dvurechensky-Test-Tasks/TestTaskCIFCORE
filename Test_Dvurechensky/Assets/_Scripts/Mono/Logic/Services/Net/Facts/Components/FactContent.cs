/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 сентября 2025 06:50:28
 * Version: 1.0.11
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