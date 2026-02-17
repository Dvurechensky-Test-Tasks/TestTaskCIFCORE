/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 февраля 2026 09:24:49
 * Version: 1.0.180
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

