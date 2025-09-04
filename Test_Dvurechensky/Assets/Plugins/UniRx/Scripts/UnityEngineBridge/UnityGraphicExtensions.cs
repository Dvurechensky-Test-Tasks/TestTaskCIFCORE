/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:07:37
 * Version: 1.0.13
 */

// for uGUI(from 4.6)
#if !(UNITY_4_0 || UNITY_4_1 || UNITY_4_2 || UNITY_4_3 || UNITY_4_4 || UNITY_4_5)

using System;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UniRx
{
    public static partial class UnityGraphicExtensions
    {
        public static IObservable<Unit> DirtyLayoutCallbackAsObservable(this Graphic graphic)
        {
            return Observable.Create<Unit>(observer =>
            {
                UnityAction registerHandler = () => observer.OnNext(Unit.Default);
                graphic.RegisterDirtyLayoutCallback(registerHandler);
                return Disposable.Create(() => graphic.UnregisterDirtyLayoutCallback(registerHandler));
            });
        }

        public static IObservable<Unit> DirtyMaterialCallbackAsObservable(this Graphic graphic)
        {
            return Observable.Create<Unit>(observer =>
            {
                UnityAction registerHandler = () => observer.OnNext(Unit.Default);
                graphic.RegisterDirtyMaterialCallback(registerHandler);
                return Disposable.Create(() => graphic.UnregisterDirtyMaterialCallback(registerHandler));
            });
        }

        public static IObservable<Unit> DirtyVerticesCallbackAsObservable(this Graphic graphic)
        {
            return Observable.Create<Unit>(observer =>
            {
                UnityAction registerHandler = () => observer.OnNext(Unit.Default);
                graphic.RegisterDirtyVerticesCallback(registerHandler);
                return Disposable.Create(() => graphic.UnregisterDirtyVerticesCallback(registerHandler));
            });
        }
    }
}

#endif