/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
 */

using System;

/// <summary>
/// Отображение таблицы Facts
/// </summary>
public class FactTableView : TableViewBase
{
    public event Action OnDisableAction = delegate {};
    
    private void OnDisable()
    {
        OnDisableAction?.Invoke();
    }
}