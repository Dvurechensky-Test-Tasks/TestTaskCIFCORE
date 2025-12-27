/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
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
