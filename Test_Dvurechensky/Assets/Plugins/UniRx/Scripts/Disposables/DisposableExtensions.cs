/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 сентября 2025 14:17:06
 * Version: 1.0.36
 */

using System;
using System.Collections.Generic;

namespace UniRx
{
    public static partial class DisposableExtensions
    {
        /// <summary>Add disposable(self) to CompositeDisposable(or other ICollection). Return value is self disposable.</summary>
        public static T AddTo<T>(this T disposable, ICollection<IDisposable> container)
            where T : IDisposable
        {
            if (disposable == null) throw new ArgumentNullException("disposable");
            if (container == null) throw new ArgumentNullException("container");

            container.Add(disposable);

            return disposable;
        }
    }
}