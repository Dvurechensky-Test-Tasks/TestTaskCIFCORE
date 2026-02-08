/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 февраля 2026 07:53:42
 * Version: 1.0.171
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

