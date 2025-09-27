/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:17:06
 * Version: 1.0.36
 */

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FactPopUpView : MonoBehaviour
{
    [Header("Имя факта")] [Space(5)] public TextMeshProUGUI NameText;
    [Header("Описание факта")] [Space(5)] public TextMeshProUGUI DescriptionText;
    [Header("Кнопка выключения окна")] [Space(5)] public Button OkBtn;
    
    public void UpdateName(string value)
    {
        NameText.text = value;
    }
    
    public void UpdateDescription(string value)
    {
        DescriptionText.text = value;
    }

    public void Close()
    {
        NameText.text = "";
        DescriptionText.text = "";
        gameObject.SetActive(false);
    }
    
    private void OnDisable()
    {
        Close();
    }
}
