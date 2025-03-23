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
