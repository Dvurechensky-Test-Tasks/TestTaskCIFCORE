/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 апреля 2026 12:57:33
 * Version: 1.0.226
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
