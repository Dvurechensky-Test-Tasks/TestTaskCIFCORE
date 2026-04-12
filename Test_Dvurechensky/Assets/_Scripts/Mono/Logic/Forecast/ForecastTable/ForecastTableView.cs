/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 апреля 2026 14:13:56
 * Version: 1.0.234
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