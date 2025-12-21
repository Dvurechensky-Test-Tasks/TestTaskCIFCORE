/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:08:31
 * Version: 1.0.122
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