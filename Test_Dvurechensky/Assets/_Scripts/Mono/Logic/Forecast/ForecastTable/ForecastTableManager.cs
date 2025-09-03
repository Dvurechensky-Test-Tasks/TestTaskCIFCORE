/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

public class ForecastTableManager : MonoBehaviour, IDisposable
{
    [Header("Интервал времени обновления таблицы")]
    [SerializeField]
    private int _perUpdateSeconds;
    
    private NetService _netService;
    private AddressableService _addressableService;
    private ObjectsPools _objectsPools;
    
    private CancellationTokenSource _cancellationDisableTokenSource;
    private ForecastTableController _controller;
    private ForecastTableView _view;

    [Inject]
    private void Construct(NetService netService,
        AddressableService addressableService, ObjectsPools pools)
    {
        Debug.Log("[ForecastTableManager] injects");
        _netService = netService;
        _addressableService = addressableService;
        _objectsPools = pools;
    }
    
    private async void OnEnable()
    {
        await Initialize();
    }
    
    private async UniTask Initialize()
    {
        _view = GetComponent<ForecastTableView>();
        _cancellationDisableTokenSource = new CancellationTokenSource();
        
        var model = new ForecastTableModel(new ForecastsContent());
        var factItemFactory = new ForecastItemFactory(_netService);
        _controller = new ForecastTableController(model, 
            _view, _addressableService, _objectsPools, _netService, factItemFactory);

        _controller.Setup();
        
        _view.OnDisableAction += OnViewDisabled;

        await _controller.StartAsync(_perUpdateSeconds, _cancellationDisableTokenSource.Token);
    }

    private async void OnViewDisabled()
    {
        await CleanupAsync();
    }

    private void OnDisable()
    {
        _cancellationDisableTokenSource?.Cancel();
        _cancellationDisableTokenSource?.Dispose();
        _cancellationDisableTokenSource = null;
        Dispose();
    }
    
    private async UniTask CleanupAsync()
    {
        _cancellationDisableTokenSource?.Cancel();
        _cancellationDisableTokenSource?.Dispose();
        _cancellationDisableTokenSource = null;
        await _controller.StopAsync();
    }

    public void Dispose()
    {
        _view.OnDisableAction -= OnViewDisabled;
    }
}