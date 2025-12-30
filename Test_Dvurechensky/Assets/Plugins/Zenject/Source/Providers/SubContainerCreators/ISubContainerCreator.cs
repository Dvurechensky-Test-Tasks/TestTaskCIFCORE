/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 декабря 2025 10:14:25
 * Version: 1.0.131
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
