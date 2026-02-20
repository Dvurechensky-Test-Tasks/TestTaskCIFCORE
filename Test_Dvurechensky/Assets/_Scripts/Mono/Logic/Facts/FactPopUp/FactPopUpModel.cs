/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 февраля 2026 13:11:53
 * Version: 1.0.183
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
