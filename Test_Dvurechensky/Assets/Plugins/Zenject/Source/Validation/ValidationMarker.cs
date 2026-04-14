/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 апреля 2026 12:23:01
 * Version: 1.0.236
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

