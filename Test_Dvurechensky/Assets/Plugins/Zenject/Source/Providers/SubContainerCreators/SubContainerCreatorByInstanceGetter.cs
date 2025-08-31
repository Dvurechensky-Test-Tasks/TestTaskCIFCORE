/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2025 07:38:17
 * Version: 1.0.9
 */

using System;
using System.Collections.Generic;
using ModestTree;

namespace Zenject
{
    [NoReflectionBaking]
    public class SubContainerCreatorByInstanceGetter : ISubContainerCreator
    {
        readonly Func<InjectContext, DiContainer> _subcontainerGetter;

        public SubContainerCreatorByInstanceGetter(
            Func<InjectContext, DiContainer> subcontainerGetter)
        {
            _subcontainerGetter = subcontainerGetter;
        }

        public DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context, out Action injectAction)
        {
            Assert.That(args.IsEmpty());

            injectAction = null;

            // It is assumed here that the subcontainer has already had ResolveRoots called elsewhere
            // Since most likely you are adding a subcontainer that is already in a context or
            // something rather than directly using DiContainer.CreateSubContainer
            return _subcontainerGetter(context);
        }
    }
}

