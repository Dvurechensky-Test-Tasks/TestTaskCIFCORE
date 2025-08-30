/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public enum NavStateEnum
{
    [Description("РћРєРЅРѕ РїРѕРіРѕРґС‹")]
    Forecast,
    [Description("РћРєРЅРѕ С„Р°РєС‚РѕРІ")]
    Facts
}

public class NavigateController : MonoBehaviour
{
    [Space(20)]
    [Header("РљРЅРѕРїРєР° РѕС‚РєСЂС‹С‚РёСЏ РѕРєРЅР° С„Р°РєС‚РѕРІ")]
    public Button FactsOpen;
    [Space(10)]
    [Header("РљРЅРѕРїРєР° РѕС‚РєСЂС‹С‚РёСЏ РѕРєРЅР° РїРѕРіРѕРґС‹")]
    public Button ForecastOpen;
    
    [Space(50)]
    
    [Header("РњРµРЅРµРґР¶РµСЂ СѓРїСЂР°РІР»РµРЅРёСЏ С‚Р°Р±Р»РёС†РµР№ РїРѕРіРѕРґС‹")]
    public ForecastTableManager ForecastTableManager;
    [Space(10)]
    [Header("РњРµРЅРµРґР¶РµСЂ СѓРїСЂР°РІР»РµРЅРёСЏ С‚Р°Р±Р»РёС†РµР№ С„Р°РєС‚РѕРІ")]
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