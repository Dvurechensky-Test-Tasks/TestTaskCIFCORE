/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 сентября 2025 17:13:59
 * Version: 1.0.32
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class DeclareSignalRequireHandlerAsyncTickPriorityCopyBinder : DeclareSignalAsyncTickPriorityCopyBinder
    {
        public DeclareSignalRequireHandlerAsyncTickPriorityCopyBinder(
            SignalDeclarationBindInfo signalBindInfo)
            : base(signalBindInfo)
        {
        }

        public DeclareSignalAsyncTickPriorityCopyBinder RequireSubscriber()
        {
            SignalBindInfo.MissingHandlerResponse = SignalMissingHandlerResponses.Throw;
            return this;
        }

        public DeclareSignalAsyncTickPriorityCopyBinder OptionalSubscriber()
        {
            SignalBindInfo.MissingHandlerResponse = SignalMissingHandlerResponses.Ignore;
            return this;
        }

        public DeclareSignalAsyncTickPriorityCopyBinder OptionalSubscriberWithWarning()
        {
            SignalBindInfo.MissingHandlerResponse = SignalMissingHandlerResponses.Warn;
            return this;
        }
    }
}

