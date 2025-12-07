/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:55:31
 * Version: 1.0.108
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