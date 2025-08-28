/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniRx
{
    /// <summary>
    /// Notify boolean flag.
    /// </summary>
    public class BooleanNotifier : IObservable<bool>
    {
        readonly Subject<bool> boolTrigger = new Subject<bool>();

        bool boolValue;
        /// <summary>Current flag value</summary>
        public bool Value
        {
            get { return boolValue; }
            set
            {
                boolValue = value;
                boolTrigger.OnNext(value);
            }
        }

        /// <summary>
        /// Setup initial flag.
        /// </summary>
        public BooleanNotifier(bool initialValue = false)
        {
            this.Value = initialValue;
        }

        /// <summary>
        /// Set and raise true if current value isn't true.
        /// </summary>
        public void TurnOn()
        {
            if (Value != true)
            {
                Value = true;
            }
        }

        /// <summary>
        /// Set and raise false if current value isn't false.
        /// </summary>
        public void TurnOff()
        {
            if (Value != false)
            {
                Value = false;
            }
        }

        /// <summary>
        /// Set and raise reverse value.
        /// </summary>
        public void SwitchValue()
        {
            Value = !Value;
        }


        /// <summary>
        /// Subscribe observer.
        /// </summary>
        public IDisposable Subscribe(IObserver<bool> observer)
        {
            return boolTrigger.Subscribe(observer);
        }
    }
}