/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 октября 2025 10:56:40
 * Version: 1.0.55
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
