/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
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

