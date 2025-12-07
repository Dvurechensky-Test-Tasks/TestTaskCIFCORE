/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 декабря 2025 12:55:31
 * Version: 1.0.108
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