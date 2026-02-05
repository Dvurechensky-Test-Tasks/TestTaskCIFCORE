/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
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