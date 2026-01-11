/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 января 2026 17:07:49
 * Version: 1.0.143
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
