/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2025 11:10:33
 * Version: 1.0.18
 */

using System;

public class ForecastItemModel
{
    private ForecastPeriodContent _content;
    public event Action<ForecastPeriodContent> OnDataChanged;

    public ForecastItemModel(ForecastPeriodContent content)
    {
        _content = content;
    }

    public void InstallData(ForecastPeriodContent content)
    {
        _content = content;
        OnDataChanged?.Invoke(content);
    }
}