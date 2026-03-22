/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 марта 2026 09:59:34
 * Version: 1.0.212
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