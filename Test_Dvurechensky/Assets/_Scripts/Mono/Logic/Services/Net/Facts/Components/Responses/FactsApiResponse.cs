/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 15:59:51
 * Version: 1.0.114
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