/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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