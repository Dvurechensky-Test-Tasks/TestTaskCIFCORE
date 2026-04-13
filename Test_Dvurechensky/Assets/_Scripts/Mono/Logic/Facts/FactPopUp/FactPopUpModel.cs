/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:57:35
 * Version: 1.0.235
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
