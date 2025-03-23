using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public enum NavStateEnum
{
    [Description("Окно погоды")]
    Forecast,
    [Description("Окно фактов")]
    Facts
}

public class NavigateController : MonoBehaviour
{
    [Space(20)]
    [Header("Кнопка открытия окна фактов")]
    public Button FactsOpen;
    [Space(10)]
    [Header("Кнопка открытия окна погоды")]
    public Button ForecastOpen;
    
    [Space(50)]
    
    [Header("Менеджер управления таблицей погоды")]
    public ForecastTableManager ForecastTableManager;
    [Space(10)]
    [Header("Менеджер управления таблицей фактов")]
    public FactTableManager FactTableManager;
    private void Awake()
    {
        FactsOpen.onClick.AddListener(() => SwitchTab(NavStateEnum.Facts));
        ForecastOpen.onClick.AddListener(() => SwitchTab(NavStateEnum.Forecast));
    }

    private void SwitchTab(NavStateEnum nav)
    {
        switch (nav)
        {
            case NavStateEnum.Forecast:
                FactTableManager.gameObject.SetActive(false);
                ForecastTableManager.gameObject.SetActive(true);
                break;
            case NavStateEnum.Facts:
                ForecastTableManager.gameObject.SetActive(false);
                FactTableManager.gameObject.SetActive(true);
                break;
        }
    }
}