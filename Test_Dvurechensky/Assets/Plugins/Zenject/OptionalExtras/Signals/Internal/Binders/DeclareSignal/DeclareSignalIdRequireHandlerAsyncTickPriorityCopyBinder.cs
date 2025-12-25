/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 декабря 2025 09:29:10
 * Version: 1.0.126
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class DeclareSignalIdRequireHandlerAsyncTickPriorityCopyBinder : DeclareSignalRequireHandlerAsyncTickPriorityCopyBinder
    {
        public DeclareSignalIdRequireHandlerAsyncTickPriorityCopyBinder(
            SignalDeclarationBindInfo signalBindInfo)
            : base(signalBindInfo)
        {
        }

        public DeclareSignalRequireHandlerAsyncTickPriorityCopyBinder WithId(object identifier)
        {
            SignalBindInfo.Identifier = identifier;
            return this;
        }
    }
}


