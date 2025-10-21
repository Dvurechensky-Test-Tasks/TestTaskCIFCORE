/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:19:39
 * Version: 1.0.60
 */

using UnityEngine;

public class TableViewBase : MonoBehaviour
{
    [Header("Точка в которой концентрируются все блоки")]
    public Transform Content;
    [Header("Объект отображающий загрузку таблицы")]
    public GameObject LoadingObj;
    
    public void ShowTableLoading(bool value)
    {
        LoadingObj.gameObject.SetActive(value);
    }
}