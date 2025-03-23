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