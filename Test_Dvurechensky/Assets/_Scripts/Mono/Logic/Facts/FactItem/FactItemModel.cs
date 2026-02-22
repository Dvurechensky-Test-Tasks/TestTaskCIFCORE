/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 февраля 2026 13:30:34
 * Version: 1.0.185
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