/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
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