/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:17:06
 * Version: 1.0.36
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