/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 марта 2026 09:59:34
 * Version: 1.0.212
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

