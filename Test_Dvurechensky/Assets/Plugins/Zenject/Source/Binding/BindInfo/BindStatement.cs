/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 августа 2025 08:33:25
 * Version: 1.0.8
 */

using System;
using System.Collections.Generic;
using ModestTree;
using Zenject.Internal;

namespace Zenject
{
    [NoReflectionBaking]
    public class BindStatement : IDisposable
    {
        readonly List<IDisposable> _disposables;
        IBindingFinalizer _bindingFinalizer;

        public BindStatement()
        {
            _disposables = new List<IDisposable>();
            Reset();
        }

        public BindingInheritanceMethods BindingInheritanceMethod
        {
            get
            {
                AssertHasFinalizer();
                return _bindingFinalizer.BindingInheritanceMethod;
            }
        }

        public bool HasFinalizer
        {
            get { return _bindingFinalizer != null; }
        }

        public void SetFinalizer(IBindingFinalizer bindingFinalizer)
        {
            _bindingFinalizer = bindingFinalizer;
        }

        void AssertHasFinalizer()
        {
            if (_bindingFinalizer == null)
            {
                throw Assert.CreateException(
                    "Unfinished binding!  Some required information was left unspecified.");
            }
        }

        public void AddDisposable(IDisposable disposable)
        {
            _disposables.Add(disposable);
        }

        public BindInfo SpawnBindInfo()
        {
            var bindInfo = ZenPools.SpawnBindInfo();
            AddDisposable(bindInfo);
            return bindInfo;
        }

        public void FinalizeBinding(DiContainer container)
        {
            AssertHasFinalizer();
            _bindingFinalizer.FinalizeBinding(container);
        }

        public void Reset()
        {
            _bindingFinalizer = null;

            for (int i = 0; i < _disposables.Count; i++)
            {
                _disposables[i].Dispose();
            }

            _disposables.Clear();
        }

        public void Dispose()
        {
            ZenPools.DespawnStatement(this);
        }
    }
}
