/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// Система управления (концентрации) пулами создаваемых объектов
/// </summary>
public class ObjectsPools : IDisposable
{
    public List<GameObject> ForecastBlocks;
    public List<GameObject> FactsBlocks;
    public List<GameObject> PopUpBlocks;
    
    private AddressableService _addressableService;

    [Inject]
    private void Construct(AddressableService addressableService)
    {
        Debug.Log("[ObjectsPools] injects");
        _addressableService = addressableService;
        FactsBlocks = new List<GameObject>();
        ForecastBlocks = new List<GameObject>();
        PopUpBlocks = new List<GameObject>();
    }
    
    public async void Dispose()
    {
        await _addressableService.ClearAllDataTableAsync(ForecastBlocks);
        await _addressableService.ClearAllDataTableAsync(FactsBlocks);
        await _addressableService.ClearAllDataTableAsync(PopUpBlocks);
    }
}