/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 сентября 2025 15:28:32
 * Version: 1.0.21
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