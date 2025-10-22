/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:45:11
 * Version: 1.0.62
 */

using System;
using UnityEngine;

/// <summary>
/// Шаблон модели хранения информации о таблице Facts
/// </summary>
public class FactTableModel
{
    private FactsContent _content;
    
    [HideInInspector] public Action<FactsContent> UpdateTableData;

    public FactTableModel(FactsContent content)
    {
        _content = content;
        InstallOrUpdateData(content);
    }

    public void InstallOrUpdateData(FactsContent content)
    {
        _content = content;
        UpdateTableData?.Invoke(content);
    }

    public int Count() => _content.Data?.Count ?? 0;

    public FactContent GetFact(int index) => _content.Data[index];
}