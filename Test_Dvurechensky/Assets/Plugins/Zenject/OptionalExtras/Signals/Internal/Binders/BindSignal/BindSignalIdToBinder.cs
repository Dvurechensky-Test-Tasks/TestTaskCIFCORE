/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 марта 2026 12:19:05
 * Version: 1.0.221
 */

using System;
using ModestTree;

namespace Zenject
{
    public class BindSignalIdToBinder<TSignal> : BindSignalToBinder<TSignal>
    {
        public BindSignalIdToBinder(DiContainer container, SignalBindingBindInfo signalBindInfo)
            : base(container, signalBindInfo)
        {
        }

        public BindSignalToBinder<TSignal> WithId(object identifier)
        {
            SignalBindInfo.Identifier = identifier;
            return this;
        }
    }
}

