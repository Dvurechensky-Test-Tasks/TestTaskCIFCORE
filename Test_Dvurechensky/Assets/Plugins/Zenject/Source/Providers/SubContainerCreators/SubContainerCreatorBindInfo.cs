/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
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
