/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:12:46
 * Version: 1.0.174
 */

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