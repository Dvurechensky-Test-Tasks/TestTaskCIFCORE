/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 ноября 2025 06:52:09
 * Version: 1.0.82
 */

using System;

public class ForecastTableView : TableViewBase
{
    public event Action OnDisableAction = delegate {};
    
    private void OnDisable()
    {
        OnDisableAction?.Invoke();
    }
}