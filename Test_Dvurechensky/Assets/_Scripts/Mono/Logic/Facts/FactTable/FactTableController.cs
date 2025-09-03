/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Шаблон обработки ввода и обновления модели таблицы Facts
/// </summary>
public class FactTableController
{
    private FactTableModel _model;
    private FactTableView _view;
    private NetService _netService;
    private AddressableService _addressableService;
    private ObjectsPools _objectsPools;
    private FactItemFactory _factItemFactory;

    public FactTableController(FactTableModel model, FactTableView view,
        NetService netService, AddressableService addressableService, 
        ObjectsPools objectsPool, FactItemFactory factory)
    {
        _model = model;
        _view = view;
        _netService = netService;
        _addressableService = addressableService;
        _objectsPools = objectsPool;
        _factItemFactory = factory;
    }

    /// <summary>
    /// Запуск
    /// </summary>
    public async UniTask StartAsync(CancellationToken token)
    {
        Debug.Log($"[FactTableController] Start data {_model.Count()} available");

        // Делаем так, чтобы View показал индикатор загрузки
        _view.ShowTableLoading(true);
        // Загружаем данные
        var content = await LoadContentAsync(token);
        // После загрузки обновляем модель
        _model.InstallOrUpdateData(content);
        // Выключаем индикатор загрузки
        _view.ShowTableLoading(false);
        
        await CreateFactTableAsync(token);
    }
    
    /// <summary>
    /// Остановка
    /// </summary>
    public async UniTask StopAsync()
    {
        Debug.Log("[FactTableController] stop");
        // очищаю таблицу от старых элементов
        await _addressableService.ClearAllDataTableAsync(_objectsPools.FactsBlocks);
        // выключаю видимость
        _view.gameObject.SetActive(false);
    }
    
    /// <summary>
    /// Метод отображения результата получения фактов
    /// </summary>
    private async UniTask CreateFactTableAsync(CancellationToken token)
    {
        await _addressableService.ClearAllDataTableAsync(_objectsPools.FactsBlocks);
        
        var tasks = new List<UniTask>();
        for (int i = 0; i < _model.Count(); i++)
        {
            if (token.IsCancellationRequested) return;

            _model.GetFact(i).Number = i + 1;
            tasks.Add(CreateFactItemAsync(_model.GetFact(i), token));
        }

        await UniTask.WhenAll(tasks);
    }
    
    /// <summary>
    /// Создание ячейки таблицы Facts
    /// </summary>
    /// <param name="content">Данные ячейки</param>
    private async UniTask CreateFactItemAsync(FactContent content, CancellationToken token)
    {
        if (token.IsCancellationRequested) return;
        
        var obj = await _addressableService.CreateBlockAsync("FactBlock",
            _view.Content, _objectsPools.FactsBlocks);
        
        if (obj != null)
        {
            var view = obj.GetComponent<FactItemView>();
            _factItemFactory.Create(view, content);
        }
    }
    
    /// <summary>
    /// Загрузка информации для таблицы
    /// </summary>
    private async UniTask<FactsContent> LoadContentAsync(CancellationToken token)
    {
        var data = await _netService.NetFactsService.GetFactsAsync(token);
        return !data.IsValidData ? null : data;
    }
}
