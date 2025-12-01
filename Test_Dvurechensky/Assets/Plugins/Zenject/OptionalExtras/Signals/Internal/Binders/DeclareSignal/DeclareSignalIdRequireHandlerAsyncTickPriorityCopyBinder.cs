/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 декабря 2025 12:47:40
 * Version: 1.0.102
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


