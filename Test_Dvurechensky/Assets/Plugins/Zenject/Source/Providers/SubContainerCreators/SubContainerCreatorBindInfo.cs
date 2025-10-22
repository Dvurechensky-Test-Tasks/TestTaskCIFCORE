/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 октября 2025 13:45:11
 * Version: 1.0.62
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
