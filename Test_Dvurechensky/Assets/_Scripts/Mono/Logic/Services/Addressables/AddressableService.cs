/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

/// <summary>
/// Система взаимодействия с объектами с помощью Addressables
/// </summary>
public class AddressableService
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public AddressableService()
    {
        Debug.Log("[AddressableService] is started");
    }
    
    /// <summary>
    /// Функция создания блока в таблице
    /// </summary>
    /// <param name="key">Имя ключа в Addressables Groups</param>
    /// <param name="parentTransform">Точка монтирования</param>
    /// <param name="blocks">Список блоков куда фиксируем созданные</param>
    /// <param name="leftSide">Добавление в начало или в конец</param>
    public async UniTask<GameObject> CreateBlockAsync(string key,
        Transform parentTransform,
        List<GameObject> blocks,
        bool leftSide = false)
    {
        var handle = Addressables.InstantiateAsync(key, 
            parentTransform);
        await handle.Task;

        if (handle.Status != AsyncOperationStatus.Succeeded)
            return null;

        var adrBlock = handle.Result;

        if (leftSide)
        {
            adrBlock.transform.SetSiblingIndex(0);
            blocks.Insert(0, adrBlock);
        }
        else
        {
            blocks.Add(adrBlock);
        }

        return adrBlock;
    }

    /// <summary>
    /// Очищает старые элементы таблицы из памяти
    /// </summary>
    /// <param name="blocks">Список элементов</param>
    public async UniTask ClearAllDataTableAsync(List<GameObject> blocks)
    {
        if (blocks == null || blocks.Count == 0) return; // Защита от ошибки
        
        Debug.Log($"[AddressableService] Blocks count before clearing: {blocks.Count}");

        blocks.ForEach(it => it.gameObject.SetActive(false));

        var blocksCopy = blocks.ToList(); // Делаем копию списка

        foreach (var block in blocksCopy)
        {
            await UniTask.Yield();
            Addressables.ReleaseInstance(block);
        }

        blocks.Clear();
    }
}