/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 апреля 2026 13:37:16
 * Version: 1.0.233
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
