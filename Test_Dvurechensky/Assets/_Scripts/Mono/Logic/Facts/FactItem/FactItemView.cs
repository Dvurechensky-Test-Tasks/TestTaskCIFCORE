/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Отображение информации ячейки таблицы Facts
/// </summary>
public class FactItemView : MonoBehaviour
{
    [Header("Текст с id факта")] [Space(5)]
    public TextMeshProUGUI IdText;

    [Header("Текст с именем факта")] [Space(5)]
    public TextMeshProUGUI NameText;

    [Header("Кнопка открытия детализации факта")] [Space(5)]
    public Button OpenDetailsFactBtn;

    [Header("Блоr загрузки")] [Space(5)] public GameObject LoadingObj;

    public event Action OnDisableAction = delegate {};
    
    public void UpdateId(string value)
    {
        IdText.text = value;
    }
    
    public void UpdateName(string value)
    {
        NameText.text = value;
    }
    
    private void Cleanup()
    {
        LoadingObj?.SetActive(false);
    }
    
    private void OnDisable()
    {
        OnDisableAction?.Invoke();
        Cleanup();
    }
}
