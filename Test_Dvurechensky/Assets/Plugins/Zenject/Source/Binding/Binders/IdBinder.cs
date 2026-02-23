/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 февраля 2026 14:21:11
 * Version: 1.0.186
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


