/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 ноября 2025 06:50:27
 * Version: 1.0.79
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

