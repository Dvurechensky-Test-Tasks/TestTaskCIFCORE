/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:17:06
 * Version: 1.0.36
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