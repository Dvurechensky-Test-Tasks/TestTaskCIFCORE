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
    public class ValidationMarker
    {
        public ValidationMarker(
            Type markedType, bool instantiateFailed)
        {
            MarkedType = markedType;
            InstantiateFailed = instantiateFailed;
        }

        public ValidationMarker(Type markedType)
            : this(markedType, false)
        {
        }

        public bool InstantiateFailed
        {
            get;
            private set;
        }

        public Type MarkedType
        {
            get;
            private set;
        }
    }
}

