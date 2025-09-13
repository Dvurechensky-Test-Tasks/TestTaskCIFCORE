/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 сентября 2025 06:50:28
 * Version: 1.0.22
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
