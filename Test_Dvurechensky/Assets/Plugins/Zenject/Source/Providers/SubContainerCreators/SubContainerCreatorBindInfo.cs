/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
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
