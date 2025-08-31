/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
 */

using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

public class FactTableManager : MonoBehaviour
{
    private NetService _netService;
    private AddressableService _addressableService;
    private ObjectsPools _objectsPools;
    
    private CancellationTokenSource _cancellationDisableTokenSource;
    private FactTableController _controller;
    
    [Inject]
    private void Construct(NetService netService,
        AddressableService addressableService, 
        ObjectsPools objectsPools)
    {
        Debug.Log("[FactTableManager] inject servers communication");
        _netService = netService;
        _addressableService = addressableService;
        _objectsPools = objectsPools;
    }

    private async void OnEnable()
    {
        await Initialize();
    }

    private async UniTask Initialize()
    {
        var mainCanvasTransform = GameObject.FindGameObjectWithTag("MainCanvas").transform;
        _cancellationDisableTokenSource = new CancellationTokenSource();
        
        var view = GetComponent<FactTableView>();
        var model = new FactTableModel(new FactsContent());
        var factItemFactory = new FactItemFactory(_addressableService, _netService, _objectsPools, mainCanvasTransform);
        _controller = new FactTableController(model, 
            view, _netService, _addressableService, _objectsPools, factItemFactory);

        view.OnDisableAction += async () => await CleanupAsync();

        await _controller.StartAsync(_cancellationDisableTokenSource.Token);
    }

    private void OnDisable()
    {
        _cancellationDisableTokenSource?.Cancel();
        _cancellationDisableTokenSource?.Dispose();
        _cancellationDisableTokenSource = null;
    }
    
    private async UniTask CleanupAsync()
    {
        _cancellationDisableTokenSource?.Cancel();
        _cancellationDisableTokenSource?.Dispose();
        _cancellationDisableTokenSource = null;
        await _controller.StopAsync();
    }
}
