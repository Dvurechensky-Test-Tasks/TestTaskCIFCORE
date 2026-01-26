/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 января 2026 06:50:27
 * Version: 1.0.158
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

