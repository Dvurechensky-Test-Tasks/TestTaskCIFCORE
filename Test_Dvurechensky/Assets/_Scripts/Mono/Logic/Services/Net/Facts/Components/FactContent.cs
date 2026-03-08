/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 марта 2026 09:54:23
 * Version: 1.0.199
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