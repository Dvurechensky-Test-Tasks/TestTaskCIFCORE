/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 19 марта 2026 06:50:28
 * Version: 1.0.209
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

