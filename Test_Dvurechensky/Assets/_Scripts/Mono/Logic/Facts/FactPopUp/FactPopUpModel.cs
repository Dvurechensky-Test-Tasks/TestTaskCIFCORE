/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:56:09
 * Version: 1.0.132
 */

using System;

/// <summary>
/// Шаблон модели хранения информации о всплывающем окне таблицы Facts
/// </summary>
public class FactPopUpModel
{
    private FactContent _content;
    
    public event Action<FactContent> OnDataChanged = delegate {};
    
    public FactPopUpModel(FactContent content)
    {
        _content = content;
    }
    
    public void InstallData(FactContent content)
    {
        _content = content; 
        OnDataChanged?.Invoke(_content);
    }
}
