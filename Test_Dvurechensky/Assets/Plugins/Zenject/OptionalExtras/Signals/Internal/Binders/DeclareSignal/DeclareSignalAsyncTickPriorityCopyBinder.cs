/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 апреля 2026 11:30:59
 * Version: 1.0.225
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

