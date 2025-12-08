/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
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