/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

using System;

public class FactPopUpController : IDisposable
{
    private FactPopUpModel _model;
    private FactPopUpView _view;
    
    public FactPopUpController(FactPopUpModel model, FactPopUpView view)
    {
        _model = model;
        _view = view;
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
        _view.UpdateName(content.Attributes.Name);
        _view.UpdateDescription(content.Attributes.Description);
    }

    private void BindView()
    {
        if(_view.OkBtn != null)
            _view.OkBtn.onClick.AddListener(Close);
    }
    
    private void Close()
    {
        _view.Close();
    }

    public void Dispose()
    {
        _model.OnDataChanged -= UpdateView;
        if (_view.OkBtn != null)
            _view.OkBtn.onClick.RemoveAllListeners();
    }
}