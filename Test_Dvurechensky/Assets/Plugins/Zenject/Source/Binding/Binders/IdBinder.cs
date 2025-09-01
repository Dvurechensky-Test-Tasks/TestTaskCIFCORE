/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 сентября 2025 11:04:53
 * Version: 1.0.10
 */

namespace Zenject
{
    [NoReflectionBaking]
    public class IdBinder
    {
        BindInfo _bindInfo;

        public IdBinder(BindInfo bindInfo)
        {
            _bindInfo = bindInfo;
        }

        public void WithId(object identifier)
        {
            _bindInfo.Identifier = identifier;
        }
    }
}


