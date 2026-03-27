/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 марта 2026 11:49:53
 * Version: 1.0.218
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
