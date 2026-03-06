/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 марта 2026 06:50:29
 * Version: 1.0.197
 */

#if !NOT_UNITY3D

namespace Zenject
{
    public interface IPrefabProvider
    {
        UnityEngine.Object GetPrefab(InjectContext context);
    }
}

#endif

