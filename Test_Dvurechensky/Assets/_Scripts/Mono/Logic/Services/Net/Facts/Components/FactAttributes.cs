/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 января 2026 17:07:49
 * Version: 1.0.143
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