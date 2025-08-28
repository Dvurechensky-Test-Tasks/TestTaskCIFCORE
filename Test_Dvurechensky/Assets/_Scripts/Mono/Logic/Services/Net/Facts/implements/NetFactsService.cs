/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

using System;
using System.Net.Http;
using System.Threading;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;
using Zenject;

/// <summary>
/// Сервис обмена сообщениями о фактах
/// </summary>
public class NetFactsService : INetFactsService
{
    private const string ApiUrl = "https://dogapi.dog/api/v2/breeds";

    private readonly HttpClient _httpClient;

    [Inject]
    public NetFactsService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "UnityApp/1.0 (your@email.com)");
    }

    /// <summary>
    /// Метод получения списка фактов
    /// </summary>
    /// <param name="cancellationToken">Token</param>
    public async UniTask<FactsContent> GetFactsAsync(CancellationToken cancellationToken)
    {
        try
        {
            // Проверка отмены перед началом запроса
            cancellationToken.ThrowIfCancellationRequested();

            HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl, cancellationToken);

            // Проверка отмены после получения ответа
            cancellationToken.ThrowIfCancellationRequested();

            if (!response.IsSuccessStatusCode)
            {
                Debug.LogError($"[NetFactsService] API request failed: {response.StatusCode}");
                return null;
            }

            string json = await response.Content.ReadAsStringAsync();

            // Проверка отмены после чтения контента
            cancellationToken.ThrowIfCancellationRequested();

            FactsApiResponse apiResponse = JsonConvert.DeserializeObject<FactsApiResponse>(json);

            return new FactsContent()
            {
                Data = apiResponse.Data
            };
        }
        catch (OperationCanceledException)
        {
            // Обработка отмены запроса
            Debug.Log("[NetFactsService] Request was cancelled.");
            return null;
        }
        catch (Exception ex)
        {
            Debug.LogError($"[NetFactsService] Error fetching facts: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Метод получения факта
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancellationToken">Token</param>
    public async UniTask<FactContent> GetFactAsync(string id, CancellationToken cancellationToken)
    {
        try
        {
            // Проверка отмены перед началом запроса
            cancellationToken.ThrowIfCancellationRequested();

            HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl + "/" + id, cancellationToken);

            // Проверка отмены после получения ответа
            cancellationToken.ThrowIfCancellationRequested();

            if (!response.IsSuccessStatusCode)
            {
                Debug.LogError($"[NetFactsService] API request failed: {response.StatusCode}");
                return null;
            }

            string json = await response.Content.ReadAsStringAsync();
            
            Debug.Log(json);
            
            // Проверка отмены после чтения контента
            cancellationToken.ThrowIfCancellationRequested();

            FactApiResponse apiResponse = JsonConvert.DeserializeObject<FactApiResponse>(json);
            
            return apiResponse.Data;
        }
        catch (OperationCanceledException)
        {
            // Обработка отмены запроса
            Debug.Log("[NetFactsService] Request was cancelled.");
            return null;
        }
        catch (Exception ex)
        {
            Debug.LogError($"[NetFactsService] Error fetching facts: {ex.Message}");
            return null;
        }
    }
}