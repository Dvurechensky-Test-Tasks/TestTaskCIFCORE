/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 февраля 2026 09:12:46
 * Version: 1.0.174
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