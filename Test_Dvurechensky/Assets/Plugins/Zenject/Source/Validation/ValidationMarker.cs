/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 декабря 2025 16:08:31
 * Version: 1.0.122
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

