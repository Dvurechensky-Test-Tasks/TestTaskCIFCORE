/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 25 февраля 2026 13:59:57
 * Version: 1.0.188
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
