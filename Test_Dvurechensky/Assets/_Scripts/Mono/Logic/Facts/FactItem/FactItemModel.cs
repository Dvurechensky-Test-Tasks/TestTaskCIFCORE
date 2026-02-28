/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
 */

using System;

/// <summary>
/// Шаблон модели хранения информации о ячейки таблицы Facts
/// </summary>
public class FactItemModel
{
    private FactContent _content;
    
    public event Action<FactContent> OnDataChanged;

    public FactItemModel(FactContent content)
    {
        _content = content;
    }

    public void InstallData(FactContent content)
    {
        _content = content;
        OnDataChanged?.Invoke(content);
    }

    public string GetId() => _content.Id;
}