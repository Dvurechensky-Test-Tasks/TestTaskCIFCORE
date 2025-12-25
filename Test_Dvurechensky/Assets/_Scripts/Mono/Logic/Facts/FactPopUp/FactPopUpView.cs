/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:29:10
 * Version: 1.0.126
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
