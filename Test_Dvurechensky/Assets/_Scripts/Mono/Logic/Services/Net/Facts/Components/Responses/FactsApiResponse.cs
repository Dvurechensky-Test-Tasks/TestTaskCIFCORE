/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:34
 * Version: 1.0.185
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