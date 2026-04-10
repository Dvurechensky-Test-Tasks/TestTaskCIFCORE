/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 апреля 2026 12:30:12
 * Version: 1.0.232
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


