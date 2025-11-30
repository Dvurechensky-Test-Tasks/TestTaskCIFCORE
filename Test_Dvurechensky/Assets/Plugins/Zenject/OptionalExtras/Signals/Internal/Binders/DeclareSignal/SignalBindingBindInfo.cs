/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 ноября 2025 14:36:10
 * Version: 1.0.101
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

