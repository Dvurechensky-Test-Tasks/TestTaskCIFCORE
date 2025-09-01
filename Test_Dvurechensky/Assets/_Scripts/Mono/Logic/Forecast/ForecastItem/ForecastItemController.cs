/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

using System;
using System.Threading;

public class ForecastItemController : IDisposable
{
    private ForecastItemModel _model;
    private ForecastItemView _view;
    private NetService _netService;

    private CancellationTokenSource _cancellationTokenSource;
    
    public ForecastItemController(ForecastItemModel model, ForecastItemView view, NetService netService)
    {
        _model = model;
        _view = view;
        _netService = netService;
    }
    
    public void Setup()
    {
        Initialize();
    }
    
    private void Initialize()
    {
        _model.OnDataChanged += UpdateView;
    }
    
    private async void UpdateView(ForecastPeriodContent content)
    {
        _view.UpdateLoadingTextsState(true);
        _view.UpdateNumber(content.Number);
        _view.UpdateName(content.Name);
        _view.UpdateTemperature($"{content.Temperature} [{content.TemperatureUnit}]");
        _view.UpdateLoadingTextsState(false);
        
        _view.UpdateImage(true);
        _cancellationTokenSource = new CancellationTokenSource();
        var texture = await _netService.INetDataService.GetTexture2DFromURLCacheAsync(content.IconURL,
            _cancellationTokenSource.Token);
        _view.UpdateImage(false, texture);
    }
    
    public void Cleanup()
    {
        // отзываю запрос
        _cancellationTokenSource?.Cancel();
        // уничтожаю подписки
        Dispose();
    }

    public void Dispose()
    {
        _cancellationTokenSource?.Dispose();
        _cancellationTokenSource = null;
        _model.OnDataChanged -= UpdateView;
    }
}