/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:16:36
 * Version: 1.0.56
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class FactsContent
{
    [JsonProperty("data")]
    public List<FactContent> Data;

    public bool IsValidData => Data != null;
}