/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:08:31
 * Version: 1.0.122
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

