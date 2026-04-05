/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 апреля 2026 15:02:26
 * Version: 1.0.227
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