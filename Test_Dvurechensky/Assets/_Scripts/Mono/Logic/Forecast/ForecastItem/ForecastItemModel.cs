/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
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