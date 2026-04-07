/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 апреля 2026 10:54:29
 * Version: 1.0.229
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