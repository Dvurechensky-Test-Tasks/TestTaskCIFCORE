/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
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