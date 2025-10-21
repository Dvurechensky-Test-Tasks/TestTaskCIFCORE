/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:19:39
 * Version: 1.0.60
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