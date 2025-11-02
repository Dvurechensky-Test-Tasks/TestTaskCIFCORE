/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:21:45
 * Version: 1.0.73
 */

using System;

namespace Zenject
{
    [NoReflectionBaking]
    public class SignalDeclarationBindInfo
    {
        public SignalDeclarationBindInfo(Type signalType)
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

        public bool RunAsync
        {
            get; set;
        }

        public int TickPriority
        {
            get; set;
        }

        public SignalMissingHandlerResponses MissingHandlerResponse
        {
            get; set;
        }
    }
}
