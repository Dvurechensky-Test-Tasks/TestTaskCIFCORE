/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 мая 2025 08:07:05
 * Version: 1.0.1
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