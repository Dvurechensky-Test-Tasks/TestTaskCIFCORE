/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 марта 2026 06:50:29
 * Version: 1.0.207
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