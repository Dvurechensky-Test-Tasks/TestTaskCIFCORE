/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:48:06
 * Version: 1.0.50
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
