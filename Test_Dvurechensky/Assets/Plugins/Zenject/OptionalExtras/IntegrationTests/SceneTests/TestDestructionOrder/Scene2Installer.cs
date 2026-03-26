/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 26 марта 2026 10:03:13
 * Version: 1.0.217
 */

using UnityEngine;
using UnityEngine.SceneManagement;

namespace Zenject.Tests.TestDestructionOrder
{
    public class SceneChangeHandler : ITickable
    {
        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("EmptyScene", LoadSceneMode.Single);
            }
        }
    }

    public class Scene2Installer : MonoInstaller<Scene2Installer>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<SceneChangeHandler>().AsSingle();
            Container.BindInterfacesTo<FooDisposable2>().AsSingle();
        }
    }
}
