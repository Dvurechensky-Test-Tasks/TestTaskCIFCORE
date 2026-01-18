/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 января 2026 15:16:45
 * Version: 1.0.150
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