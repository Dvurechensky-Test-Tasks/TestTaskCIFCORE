/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
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


