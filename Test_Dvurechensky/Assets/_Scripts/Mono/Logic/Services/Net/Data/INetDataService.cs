/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
 */

using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Шаблон системы запроса данных
/// </summary>
public interface INetDataService
{
    UniTask<Texture2D> GetTexture2DFromURLCacheAsync(string url, CancellationToken token);
}