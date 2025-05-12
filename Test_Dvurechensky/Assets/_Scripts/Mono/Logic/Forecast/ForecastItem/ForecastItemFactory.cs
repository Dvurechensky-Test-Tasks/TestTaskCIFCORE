/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
 */

public class ForecastItemFactory
{
    private NetService _netService;

    private ForecastItemModel _model;
    
    public ForecastItemFactory(NetService netService)
    {
        _netService = netService;
    }

    public ForecastItemController Create(ForecastItemView view, ForecastPeriodContent content)
    {
        _model = new ForecastItemModel(content);
        var controller = new ForecastItemController(_model, view, _netService);

        controller.Setup();
        
        view.OnDisableAction += controller.Cleanup;
        
        _model.InstallData(content);
        return controller;
    }

    public void Update(ForecastItemView view, ForecastPeriodContent content)
    {
        if (_model != null)
            _model.InstallData(content);
    }
}