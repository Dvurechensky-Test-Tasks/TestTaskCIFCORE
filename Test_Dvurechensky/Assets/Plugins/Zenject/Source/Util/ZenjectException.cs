/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 декабря 2025 13:05:34
 * Version: 1.0.109
 */

using System;
using System.Diagnostics;

namespace Zenject
{
    [DebuggerStepThrough]
    [NoReflectionBaking]
    public class ZenjectException : Exception
    {
        public ZenjectException(string message)
            : base(message)
        {
        }

        public ZenjectException(
            string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
