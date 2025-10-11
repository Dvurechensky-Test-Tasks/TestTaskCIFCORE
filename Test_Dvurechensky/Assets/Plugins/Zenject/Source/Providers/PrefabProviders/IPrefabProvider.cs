/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:48:06
 * Version: 1.0.50
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

