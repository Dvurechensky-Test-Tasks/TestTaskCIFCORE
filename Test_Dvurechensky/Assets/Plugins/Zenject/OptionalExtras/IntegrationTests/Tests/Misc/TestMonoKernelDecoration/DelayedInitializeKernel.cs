/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
 */

using System.Threading.Tasks;
using Zenject;

namespace Zenject.Tests.TestAnimationStateBehaviourInject
{
    public class DelayedInitializeKernel : BaseMonoKernelDecorator
    {
        public async override void Initialize()
        {
            await Task.Delay(5000);
            DecoratedMonoKernel.Initialize();
        }
    }
}