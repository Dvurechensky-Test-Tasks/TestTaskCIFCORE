/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 марта 2026 10:12:55
 * Version: 1.0.216
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