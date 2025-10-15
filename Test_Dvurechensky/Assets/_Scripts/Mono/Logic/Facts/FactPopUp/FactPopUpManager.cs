/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 октября 2025 10:47:49
 * Version: 1.0.54
 */

using UnityEngine;

public class FactPopUpManager : MonoBehaviour
{
    private FactPopUpController _controller;
    
    public void Initialize(FactContent content)
    {
        var view = GetComponent<FactPopUpView>();
        
        var model = new FactPopUpModel(content);
        _controller = new FactPopUpController(model, view);

        _controller.Setup();
        
        model.InstallData(content);
    }

    private void OnDisable()
    {
        _controller.Dispose();
    }
}