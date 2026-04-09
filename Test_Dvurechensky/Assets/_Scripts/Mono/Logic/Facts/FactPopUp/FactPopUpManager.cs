/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 апреля 2026 10:55:50
 * Version: 1.0.231
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