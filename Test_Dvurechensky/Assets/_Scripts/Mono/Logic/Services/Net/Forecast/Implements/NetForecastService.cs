/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
 */

using System;
using System.Net.Http;
using System.Threading;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;
using Zenject;

/// <summary>
/// Cервис запроса прогноза погоды
/// </summary>
public class NetForecastService : INetForecastService
{
    private const string ApiUrl = "https://api.weather.gov/gridpoints/TOP/32,81/forecast";
    private readonly HttpClient _httpClient;
    
    [Inject]
    public NetForecastService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "UnityApp/1.0 (your@email.com)");
    }
    
    /// <summary>
    /// Метод получения информации о погоде
    /// </summary>
    /// <param name="cancellationToken">Token</param>
    public async UniTask<ForecastsContent> GetForecastAsync(CancellationToken cancellationToken)
    {
        try
        {
            Debug.Log("[NetForecastService] GetForecastAsync...");
            // Проверка отмены перед началом запроса
            cancellationToken.ThrowIfCancellationRequested();
            
            HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl, cancellationToken);
            
            // Проверка отмены после получения ответа
            cancellationToken.ThrowIfCancellationRequested();
            
            if (!response.IsSuccessStatusCode)
            {
                Debug.LogError($"[NetForecastService] API request failed: {response.StatusCode}");
                return null;
            }

            string json = await response.Content.ReadAsStringAsync();
          
            // Проверка отмены после чтения контента
            cancellationToken.ThrowIfCancellationRequested();
            
            ForecastApiResponse apiResponse = JsonConvert.DeserializeObject<ForecastApiResponse>(json);
            return apiResponse.Properties;
        }
        catch (OperationCanceledException)
        {
            // Обработка отмены запроса
            Debug.Log("[NetForecastService] Request was cancelled.");
            return null;
        }
        catch (Exception ex)
        {
            Debug.LogError($"[NetForecastService] Error fetching forecast: {ex.Message}");
            return null;
        }
    }
}