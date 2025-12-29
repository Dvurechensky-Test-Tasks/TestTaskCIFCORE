/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 декабря 2025 09:56:42
 * Version: 1.0.130
 */

using System;

namespace Zenject
{
    [NoReflectionBaking]
    public class SignalBindingBindInfo
    {
        public SignalBindingBindInfo(Type signalType)
        {
            SignalType = signalType;
        }

        public object Identifier
        {
            get; set;
        }

        public Type SignalType
        {
            get; private set;
        }
    }
}

