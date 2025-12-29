/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 декабря 2025 09:56:42
 * Version: 1.0.130
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class FactsApiResponse
{
    [JsonProperty("data")]
    public List<FactContent> Data;

    public bool IsValidData => Data != null;
}