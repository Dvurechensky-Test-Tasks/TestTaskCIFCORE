/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 февраля 2026 15:54:06
 * Version: 1.0.191
 */

using UnityEngine.SceneManagement;

namespace Zenject.Tests.TestDestructionOrder
{
    public class Scene1Installer : MonoInstaller<Scene1Installer>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<FooDisposable1>().AsSingle();

            SceneManager.LoadScene("TestDestructionOrder2", LoadSceneMode.Additive);
        }
    }
}
