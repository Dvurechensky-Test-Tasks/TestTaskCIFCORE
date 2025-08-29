/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:50:28
 * Version: 1.0.7
 */

using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ForecastItemView : MonoBehaviour
{
    [Header("Изображение погоды")] [Space(5)] public Image IconImage;
    [Header("Текст с названием погоды")] [Space(5)] public TextMeshProUGUI NameText;
    [Header("Текст с температурой погоды")] [Space(5)] public TextMeshProUGUI TemperatureText;
    [Header("Элемент загрузки иконки")] [Space(5)] public GameObject LoadingIcon;
    [Header("Все элементы загрузки текста")] [Space(5)] public List<GameObject> LoadingTexts;
    [Space(20)] 
    [Header("Стандартное изображение погоды")]
    public Texture2D DefaultForecastImg;

    public event Action OnDisableAction = delegate {};
    private Texture DefaultImage => DefaultForecastImg;
    private string Number;

    public void UpdateImage(bool wait, Texture2D texture = null)
    {
        if (wait)
        {
            LoadingIcon.gameObject.SetActive(true);
            ImageView = DefaultImage;
        }
        else
        {
            LoadingIcon.gameObject.SetActive(false);
            ImageView = texture;
        }
    }
    
    public void UpdateNumber(string number)
    {
        Number = number;
    }
    
    public void UpdateName(string value)
    {
        NameText.text = value;
    }
    
    public void UpdateTemperature(string value)
    {
        TemperatureText.text = value;
    }

    public void UpdateLoadingTextsState(bool state)
    {
        LoadingTexts.ForEach((obj) => obj.gameObject.SetActive(state));
    }
    
    private Texture ImageView
    {
        get => IconImage.mainTexture;
        set
        {
            // Если изображение пустое, использовать картинку по-умолчанию
            Texture posterImage = value != null ? value : DefaultImage;
            // Установить выбранное изображение 
            IconImage.sprite = Sprite.Create((Texture2D)posterImage,
                new Rect(0, 0, posterImage.width, posterImage.height), Vector2.zero);
        }
    }
    
    private void Cleanup()
    {
        // выключаю загрузочные блоки в текстовых полях
        UpdateLoadingTextsState(false);
        // выключаю загрузочный блок изображения
        LoadingIcon.gameObject.SetActive(false);
    }
    
    private void OnDisable()
    {
        OnDisableAction?.Invoke();
        Cleanup();
    }

    public string GetNumber()
    {
        return Number;
    }
}