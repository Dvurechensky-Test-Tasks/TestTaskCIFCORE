/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class IfNotBoundBinder
    {
        public IfNotBoundBinder(BindInfo bindInfo)
        {
            BindInfo = bindInfo;
        }

        // Do not use this
        public BindInfo BindInfo
        {
            get;
            private set;
        }

        public void IfNotBound()
        {
            BindInfo.OnlyBindIfNotBound = true;
        }
    }
}

