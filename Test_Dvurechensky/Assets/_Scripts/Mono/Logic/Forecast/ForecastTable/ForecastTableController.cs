/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
 */

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ForecastTableController
{
    private ForecastTableModel _model;
    private ForecastTableView _view;
    private NetService _netService;
    private AddressableService _addressableService;
    private ObjectsPools _objectsPools;
    private ForecastItemFactory _forecastItemFactory;

    private List<ForecastItemController> _controllers = new ();
    private bool _isUpdateState;

    public ForecastTableController(ForecastTableModel model, ForecastTableView view,
        AddressableService addressableService, ObjectsPools objectsPool, NetService netService, ForecastItemFactory factory)
    {
        _model = model;
        _view = view;
        _addressableService = addressableService;
        _netService = netService;
        _objectsPools = objectsPool;
        _forecastItemFactory = factory;
    }

    public void Setup()
    {
        _model.OnDataUpdated += async content => await UpdateExistingBlocks(content);
    }
    
    /// <summary>
    /// Запуск
    /// </summary>
    public async UniTask StartAsync(int perSecond, CancellationToken token)
    {
        Debug.Log($"[ForecastTableController] Start update data {_model.Count()} available");
        _isUpdateState = true;
        // Делаем так, чтобы View показал индикатор загрузки
        _view.ShowTableLoading(true);
        // Загружаем данные
        var content = await LoadContentAsync(token);
        // После загрузки обновляем модель
        _model.InstallOrUpdateData(content);
        // Выключаем индикатор загрузки
        _view.ShowTableLoading(false);

        await CreateForecastTableAsync(token);
        await PermanentUpdateTable(perSecond, token);
    }
    
    /// <summary>
    /// Остановка
    /// </summary>
    public async UniTask StopAsync()
    {
        Debug.Log("[ForecastTableController] stop");
        // останавливаю обновление таблицы
        _isUpdateState = false;
        // очищаю таблицу от старых элементов
        await _addressableService.ClearAllDataTableAsync(_objectsPools.ForecastBlocks);
        // выключаю видимость
        _view.gameObject.SetActive(false);
    }
    
    /// <summary>
    /// Метод отображения результата получения погоды
    /// </summary>
    private async UniTask CreateForecastTableAsync(CancellationToken token)
    {
        await _addressableService.ClearAllDataTableAsync(_objectsPools.ForecastBlocks);
        
        var tasks = new List<UniTask>();
        for (int i = 0; i < _model.Count(); i++)
        {
            if (token.IsCancellationRequested) return;
            tasks.Add(CreateForecastItemAsync(_model.GetForecast(i), token));
        }

        await UniTask.WhenAll(tasks);
    }
    
    /// <summary>
    /// Создание ячейки таблицы Forecast
    /// </summary>
    /// <param name="content">Данные ячейки</param>
    private async UniTask CreateForecastItemAsync(ForecastPeriodContent content, CancellationToken token)
    {
        if (token.IsCancellationRequested) return;
        
        var obj = await _addressableService.CreateBlockAsync("ForecastBlock",
            _view.Content, _objectsPools.ForecastBlocks);
        
        if (obj != null)
        {
            var view = obj.GetComponent<ForecastItemView>();
            _controllers.Add(_forecastItemFactory.Create(view, content));
        }
    }
    
    /// <summary>
    /// Метод обновления таблицы погоды
    /// </summary>
    /// <param name="perSecond">Период обновления</param>
    /// <param name="cancellationToken">Token</param>
    private async UniTask PermanentUpdateTable(int perSecond, CancellationToken cancellationToken)
    {
        while (_isUpdateState)
        {
            // Ждём указанное количество секунд
            await UniTask.Delay(perSecond * 1000, cancellationToken: cancellationToken);

            // Проверяем, была ли отмена
            if (cancellationToken.IsCancellationRequested)
            {
                Debug.Log("[ForecastTableController] Forecast data update cancelled.");
                // Выход из метода, если отмена запроса
                return; 
            }

            // Получаем данные погоды
            var data = await LoadContentAsync(cancellationToken);

            Debug.Log("[ForecastTableController] updating forecast data every " + perSecond + " seconds");

            // Обновляем старые блоки новыми данными
            _model.InstallOrUpdateData(data);
        }
    }
    
    /// <summary>
    /// Загрузка информации для таблицы
    /// </summary>
    private async UniTask<ForecastsContent> LoadContentAsync(CancellationToken token)
    {
        var data = await _netService.NetForecastService.GetForecastAsync(token);
        return !data.IsValidData ? null : data;
    }
    
    /// <summary>
    /// Метод обновления инфомрации в блоках погоды без их удаления
    /// </summary>
    /// <param name="forecastsContent">ForecastData</param>
    private async UniTask UpdateExistingBlocks(ForecastsContent forecastsContent)
    {
        // Проходим по всем блокам и обновляем только тот, который соответствует новому данным.
        foreach (var block in _objectsPools.ForecastBlocks)
        {
            var view = block.GetComponent<ForecastItemView>();
            // Ищем период с таким же номером
            var matchingPeriod = forecastsContent.Periods.FirstOrDefault(p 
                => p.Number == view.GetNumber());
            _forecastItemFactory.Update(view, matchingPeriod);
        }
    }
}