/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:30:59
 * Version: 1.0.225
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