/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:45:11
 * Version: 1.0.62
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

