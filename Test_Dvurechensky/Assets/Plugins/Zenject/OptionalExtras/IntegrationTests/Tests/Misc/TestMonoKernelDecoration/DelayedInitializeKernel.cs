/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 октября 2025 17:05:47
 * Version: 1.0.70
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