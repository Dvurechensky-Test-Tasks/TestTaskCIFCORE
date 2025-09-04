/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using System.Threading;
using Cysharp.Threading.Tasks;

/// <summary>
/// Шаблон сервиса запроса прогноза погоды
/// </summary>
public interface INetForecastService
{
    /// <summary>
    /// Метод получения информации о погоде
    /// </summary>
    /// <param name="cancellationToken">Token</param>
    UniTask<ForecastsContent> GetForecastAsync(CancellationToken cancellationToken);
}
