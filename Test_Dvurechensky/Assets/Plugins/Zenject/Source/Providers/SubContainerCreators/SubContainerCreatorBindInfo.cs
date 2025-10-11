/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 октября 2025 08:48:06
 * Version: 1.0.50
 */

using System;

namespace Zenject
{
    [NoReflectionBaking]
    public class SubContainerCreatorBindInfo
    {
        // Null = means no custom default parent
        public string DefaultParentName
        {
            get; set;
        }

        public bool CreateKernel
        {
            get; set;
        }

        public Type KernelType
        {
            get; set;
        }
    }
}
