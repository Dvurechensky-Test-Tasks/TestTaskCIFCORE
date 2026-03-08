/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 марта 2026 09:54:23
 * Version: 1.0.199
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


