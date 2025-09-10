/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 сентября 2025 14:28:34
 * Version: 1.0.19
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

