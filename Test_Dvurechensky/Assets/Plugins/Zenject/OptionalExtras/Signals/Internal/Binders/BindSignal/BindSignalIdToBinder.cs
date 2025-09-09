/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 сентября 2025 11:10:33
 * Version: 1.0.18
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

