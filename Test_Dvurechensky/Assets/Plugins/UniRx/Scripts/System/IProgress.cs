/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 сентября 2025 07:55:35
 * Version: 1.0.12
 */

// defined from .NET Framework 4.5 and NETFX_CORE

#if !(NETFX_CORE || NET_4_6 || NET_STANDARD_2_0 || UNITY_WSA_10_0)

using System;

namespace UniRx
{
    public interface IProgress<T>
    {
        void Report(T value);
    }

    public class Progress<T> : IProgress<T>
    {
        readonly Action<T> report;

        public Progress(Action<T> report)
        {
            this.report = report;
        }

        public void Report(T value)
        {
            report(value);
        }
    }
}

#endif