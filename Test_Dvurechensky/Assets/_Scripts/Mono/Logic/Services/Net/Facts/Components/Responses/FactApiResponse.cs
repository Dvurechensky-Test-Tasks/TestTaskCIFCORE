/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 января 2026 10:22:21
 * Version: 1.0.139
 */

using System;
using Newtonsoft.Json;

[Serializable]
public class FactApiResponse
{
    [JsonProperty("data")]
    public FactContent Data;

    public bool IsValidData => Data != null;
}