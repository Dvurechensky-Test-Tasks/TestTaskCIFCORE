/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 октября 2025 06:50:28
 * Version: 1.0.40
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