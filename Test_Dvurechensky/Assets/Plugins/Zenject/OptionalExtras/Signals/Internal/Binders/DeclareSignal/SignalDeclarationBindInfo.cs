/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
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
