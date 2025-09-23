/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
 */

using System;

namespace Zenject
{
    public class SceneContextRegistryAdderAndRemover : IInitializable, IDisposable
    {
        readonly SceneContextRegistry _registry;
        readonly SceneContext _sceneContext;

        public SceneContextRegistryAdderAndRemover(
            SceneContext sceneContext,
            SceneContextRegistry registry)
        {
            _registry = registry;
            _sceneContext = sceneContext;
        }

        public void Initialize()
        {
            _registry.Add(_sceneContext);
        }

        public void Dispose()
        {
            _registry.Remove(_sceneContext);
        }
    }
}

