/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 декабря 2025 10:46:12
 * Version: 1.0.124
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class FactAttributes
{
    [JsonProperty("name")]
    public string Name;
    [JsonProperty("description")]
    public string Description;
}