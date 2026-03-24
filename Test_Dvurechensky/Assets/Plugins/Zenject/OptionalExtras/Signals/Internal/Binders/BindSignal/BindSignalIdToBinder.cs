/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 марта 2026 08:52:35
 * Version: 1.0.215
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

