/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 марта 2026 07:54:19
 * Version: 1.0.213
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
