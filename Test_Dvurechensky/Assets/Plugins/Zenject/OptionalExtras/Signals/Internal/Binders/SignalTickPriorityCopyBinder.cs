/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 января 2026 17:28:28
 * Version: 1.0.147
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class SignalTickPriorityCopyBinder : SignalCopyBinder
    {
        public SignalTickPriorityCopyBinder(
            SignalDeclarationBindInfo signalBindInfo)
        {
            SignalBindInfo = signalBindInfo;
        }

        protected SignalDeclarationBindInfo SignalBindInfo
        {
            get; private set;
        }

        public SignalCopyBinder WithTickPriority(int priority)
        {
            SignalBindInfo.TickPriority = priority;
            SignalBindInfo.RunAsync = true;
            return this;
        }
    }
}

