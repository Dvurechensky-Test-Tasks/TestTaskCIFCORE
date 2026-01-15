/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
 */

using System;

public class ForecastTableModel
{
    private ForecastsContent _content;
    public event Action<ForecastsContent> OnDataUpdated;
    
    public ForecastTableModel(ForecastsContent content)
    {
        _content = content;
        InstallOrUpdateData(content);
    }
    
    public void InstallOrUpdateData(ForecastsContent content)
    {
        _content = content;
        OnDataUpdated?.Invoke(_content);
    }

    public int Count() => _content.Periods?.Count ?? 0;

    public ForecastPeriodContent GetForecast(int index) => _content.Periods[index];
}