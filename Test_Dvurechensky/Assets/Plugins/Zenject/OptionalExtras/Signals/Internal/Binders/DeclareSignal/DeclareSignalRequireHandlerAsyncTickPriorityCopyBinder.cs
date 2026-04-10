/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
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

