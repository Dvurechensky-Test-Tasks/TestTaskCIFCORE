/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 февраля 2026 09:41:14
 * Version: 1.0.190
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class DeclareSignalAsyncTickPriorityCopyBinder : SignalTickPriorityCopyBinder
    {
        public DeclareSignalAsyncTickPriorityCopyBinder(SignalDeclarationBindInfo signalBindInfo)
            : base(signalBindInfo)
        {
        }

        public SignalTickPriorityCopyBinder RunAsync()
        {
            SignalBindInfo.RunAsync = true;
            return this;
        }

        public SignalCopyBinder RunSync()
        {
            SignalBindInfo.RunAsync = false;
            return this;
        }
    }
}

