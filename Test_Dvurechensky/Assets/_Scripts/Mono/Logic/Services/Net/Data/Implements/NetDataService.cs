/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Zenject;

public class NetDataService : INetDataService
{
    [Inject]
    public NetDataService() { }
    
    public async UniTask<Texture2D> GetTexture2DFromURLCacheAsync(string url, CancellationToken token)
    {
        if (string.IsNullOrEmpty(url))
        {
            Debug.Log("[NetDataService] Error: Texture URL is null or empty!");
            return null;
        }

        // Получаем безопасное имя файла
        string fileName = GetSafeFileNameFromUrl(url);
        string pathSave = Application.persistentDataPath + "/" + fileName;

        // запрашиваю файл из кеша если он есть
        if (File.Exists(pathSave))
        {
            var texture = await LoadTextureFromFileAsync(token, pathSave);
            if (texture != null) return texture;
        }

        // запрашиваю файл по ссылке
        using (UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url))
        {
            await webRequest.SendWebRequest().WithCancellation(token);
            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("[NetDataService] Error: '" + webRequest.error + "'\nurl: " + url);
                return null;
            }

            var texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
            byte[] data = webRequest.downloadHandler.data;
            
            using (FileStream fs = new FileStream(pathSave, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                await fs.WriteAsync(data, 0, data.Length, token);
            }
            
            // Запускаем сохранение в фоне
            SaveTextureToFileAsync(pathSave, data, token).Forget();
            
            return texture;
        }
    }
    
    /// <summary>
    /// Сохраняет текстуру в файл без блокировки основного потока.
    /// </summary>
    /// <param name="path">string</param>
    /// <param name="data">byte[]</param>
    /// <param name="token">CancellationToken</param>
    private async UniTaskVoid SaveTextureToFileAsync(string path, byte[] data, CancellationToken token)
    {
        try
        {
            await using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            await fs.WriteAsync(data, 0, data.Length, token);
        }
        catch (Exception ex)
        {
            Debug.LogError("[NetDataService] Error saving texture: " + ex);
        }
    }

    /// <summary>
    /// Получение текстуры файла с сервера
    /// </summary>
    /// <param name="token">CancellationToken</param>
    /// <param name="pathSave">string</param>
    private async Task<Texture2D> LoadTextureFromFileAsync(CancellationToken token, string pathSave)
    {
        using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture("file:///" + pathSave);
        await webRequest.SendWebRequest().WithCancellation(token);
        if (webRequest.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("[NetDataService] Error: " + webRequest.error);
            return null;
        }

        return ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
    }

    /// <summary>
    /// Конвертация URL в уникальное имя файла
    /// </summary>
    /// <param name="url">string</param>
    private string GetSafeFileNameFromUrl(string url)
    {
        // Убираем неподобающие символы
        string safeUrl = url.Replace("?", "_").Replace("&", "_").Replace("=", "_").Replace("/", "_");

        // Генерируем хеш от URL, чтобы получить уникальное, короткое имя
        using (MD5 md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(safeUrl));
            string fileName = BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Получаем строку в шестнадцатеричной форме

            // Ограничиваем длину имени файла, чтобы избежать слишком длинных имен
            const int nameLength = 32;
            if (fileName.Length > nameLength)
            {
                fileName = fileName.Substring(0, nameLength);
            }

            return fileName;
        }
    }
}