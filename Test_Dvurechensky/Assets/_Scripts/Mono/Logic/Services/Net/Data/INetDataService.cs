/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 февраля 2026 13:11:53
 * Version: 1.0.183
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