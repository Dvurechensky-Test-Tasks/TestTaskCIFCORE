/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 октября 2025 08:37:12
 * Version: 1.0.46
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