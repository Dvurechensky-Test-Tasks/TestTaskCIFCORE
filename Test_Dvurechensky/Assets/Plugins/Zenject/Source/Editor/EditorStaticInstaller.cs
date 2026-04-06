/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 апреля 2026 12:46:40
 * Version: 1.0.228
 */


namespace Zenject
{
    // Derive from this class, add [InitializeOnLoad], and then call Install
    // in a static constructor to add some editor time bindings
    // For example:
    //
    // [InitializeOnLoad]
    // public class FooInstaller : EditorStaticInstaller<FooInstaller>
    // {
    //     static FooInstaller()
    //     {
    //         Install();
    //     }
    //
    //     public override void InstallBindings()
    //     {
    //         Container.BindInstance("hello world");
    //     }
    // }
    //
    public abstract class EditorStaticInstaller<T> : InstallerBase
        where T : EditorStaticInstaller<T>
    {
        public static void Install()
        {
            StaticContext.Container.Instantiate<T>().InstallBindings();
        }
    }
}
