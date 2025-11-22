/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 ноября 2025 10:15:56
 * Version: 1.0.93
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