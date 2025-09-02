/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 сентября 2025 06:50:28
 * Version: 1.0.11
 */

using System;
using UnityEngine;
using Zenject;

/// <summary>
/// Менеджер по взаимодействию с серверами
/// </summary>
public class NetService : IDisposable
{
    public INetFactsService NetFactsService;
    public INetForecastService NetForecastService;
    public INetDataService INetDataService;
    
    [Inject]
    private void Construct(INetForecastService netForecastService, 
        INetDataService netDataService,
        INetFactsService netFactsService)
    {
        Debug.Log("[NetService] inject servers communication");
        NetForecastService = netForecastService;
        INetDataService = netDataService;
        NetFactsService = netFactsService;
    }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    public NetService()
    {
        Debug.Log("[NetService] is started");
    }

    /// <summary>
    /// Метод очистки сборщиком мусора
    /// </summary>
    public void Dispose()
    {
        NetForecastService = null;
    }
}