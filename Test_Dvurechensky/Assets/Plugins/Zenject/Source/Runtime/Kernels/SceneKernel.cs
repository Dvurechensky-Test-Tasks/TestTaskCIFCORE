/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 января 2026 10:38:53
 * Version: 1.0.159
 */

#if !NOT_UNITY3D

using ModestTree;

namespace Zenject
{
    public class SceneKernel : MonoKernel
    {
        // Only needed to set "script execution order" in unity project settings

#if ZEN_INTERNAL_PROFILING
        public override void Start()
        {
            base.Start();
            Log.Info("SceneContext.Awake detailed profiling: {0}", ProfileTimers.FormatResults());
        }
#endif
    }
}

#endif
