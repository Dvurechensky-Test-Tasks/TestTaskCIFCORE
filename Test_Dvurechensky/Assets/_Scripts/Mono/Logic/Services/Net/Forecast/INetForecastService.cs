/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 ноября 2025 06:50:27
 * Version: 1.0.76
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
