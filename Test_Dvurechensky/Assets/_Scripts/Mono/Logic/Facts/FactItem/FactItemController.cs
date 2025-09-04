/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Шаблон обработки ввода и обновления модели ячейки таблицы Facts
/// </summary>
public class FactItemController : IDisposable
{
    private FactItemModel _model;
    private FactItemView _view;
    private AddressableService _addressableService;
    private NetService _netService;
    private ObjectsPools _objectsPool;
    private Transform _mainCanvasTransform;
    
    private CancellationTokenSource _cancellationDisableTokenSource;
    
    public FactItemController(FactItemModel model, FactItemView view,
        AddressableService addressableService, NetService netService, 
        ObjectsPools objectsPool, Transform mainCanvasTransform)
    {
        _model = model;
        _view = view;
        _addressableService = addressableService;
        _netService = netService;
        _objectsPool = objectsPool;
        _mainCanvasTransform = mainCanvasTransform;
    }

    public void Setup()
    {
        Initialize();
        BindView();
    }

    private void Initialize()
    {
        _model.OnDataChanged += UpdateView;
    }
    
    private void UpdateView(FactContent content)
    {
        _view.UpdateId(content.Number.ToString());
        _view.UpdateName(content.Attributes.Name);
    }

    private void BindView()
    {
        if (_view.OpenDetailsFactBtn != null)
            _view.OpenDetailsFactBtn.onClick.AddListener(async 
                () => await OpenDetailsFact());
    }
    
    /// <summary>
    /// Метод открытия окна детализации факта
    /// </summary>
    private async UniTask OpenDetailsFact()
    {
        Debug.Log("[FactItemController] Open details fact start...");
        // включаю объект загрузки
        _view.LoadingObj.gameObject.SetActive(true);
        // формирую токен отмены запроса
        _cancellationDisableTokenSource = new CancellationTokenSource();
        // получаю информацию о факте 
        var data = await _netService.NetFactsService.GetFactAsync(_model.GetId(), 
            _cancellationDisableTokenSource.Token);
        // очищаю Canvas от старой PopUp
        await _addressableService.ClearAllDataTableAsync(_objectsPool.PopUpBlocks);
        // создаю экземпляр всплывающего окна
        var obj = await _addressableService.CreateBlockAsync("FactPopUp",
            _mainCanvasTransform.gameObject.transform, _objectsPool.PopUpBlocks);
        if (obj != null) SetupInfo(obj, data);
        _view.LoadingObj.gameObject.SetActive(false);
    }
    
    /// <summary>
    /// Метод установки информации в окно детализации факта
    /// </summary>
    /// <param name="item"></param>
    /// <param name="content"></param>
    private async void SetupInfo(GameObject item, FactContent content)
    {
        var controller = item.GetComponent<FactPopUpManager>();
        controller.Initialize(content);
    }
    
    public void Cleanup()
    {
        // закрываю PopUp
        _objectsPool.PopUpBlocks.ForEach(obj => obj.SetActive(false));
        // отзываю запрос
        _cancellationDisableTokenSource?.Cancel();
        // уничтожаю подписки
        Dispose();
    }

    public void Dispose()
    {
        _cancellationDisableTokenSource?.Dispose();
        _cancellationDisableTokenSource = null;
        _model.OnDataChanged -= UpdateView;
        if (_view.OpenDetailsFactBtn != null)
            _view.OpenDetailsFactBtn.onClick.RemoveAllListeners();
    }
}