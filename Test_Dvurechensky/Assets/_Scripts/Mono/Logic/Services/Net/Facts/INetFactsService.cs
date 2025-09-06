/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
 */

using System.Threading;
using Cysharp.Threading.Tasks;

/// <summary>
/// Шаблон сервиса обмена сообщениями о фактах
/// </summary>
public interface INetFactsService
{
    /// <summary>
    /// Метод получения списка фактов
    /// </summary>
    /// <param name="cancellationToken">Token</param>
    UniTask<FactsContent> GetFactsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Метод получения факта
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancellationToken">Token</param>
    UniTask<FactContent> GetFactAsync(string id, CancellationToken cancellationToken);
}