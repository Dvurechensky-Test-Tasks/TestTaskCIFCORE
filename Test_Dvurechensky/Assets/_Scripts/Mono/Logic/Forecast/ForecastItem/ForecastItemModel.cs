/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 января 2026 06:50:28
 * Version: 1.0.152
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