/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
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