/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 февраля 2026 10:31:34
 * Version: 1.0.175
 */

using System.Collections.Generic;
using System;

namespace Zenject
{
    public interface ISubContainerCreator
    {
        DiContainer CreateSubContainer(List<TypeValuePair> args, InjectContext context, out Action injectAction);
    }
}
