/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 сентября 2025 11:44:34
 * Version: 1.0.15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using ModestTree;

namespace Zenject
{
    public static class ValidationUtil
    {
        // This method can be used during validation for cases where we need to pass arguments
        public static List<TypeValuePair> CreateDefaultArgs(params Type[] argTypes)
        {
            return argTypes.Select(x => new TypeValuePair(x, x.GetDefaultValue())).ToList();
        }
    }
}

