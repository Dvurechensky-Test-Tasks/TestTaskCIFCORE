using UnityEngine;

public class FactItemFactory
{
    private AddressableService _addressableService;
    private NetService _netService;
    private ObjectsPools _objectsPool;
    private Transform _mainCanvasTransform;

    public FactItemFactory(AddressableService addressableService, NetService netService, 
        ObjectsPools objectsPool, Transform mainCanvasTransform)
    {
        _addressableService = addressableService;
        _netService = netService;
        _objectsPool = objectsPool;
        _mainCanvasTransform = mainCanvasTransform;
    }
    
    public void Create(FactItemView view, FactContent content)
    {
        var model = new FactItemModel(content);
        var controller = new FactItemController(model, view, _addressableService, _netService, _objectsPool, _mainCanvasTransform);

        controller.Setup();
        
        view.OnDisableAction += controller.Cleanup;
        
        model.InstallData(content);
    }
}