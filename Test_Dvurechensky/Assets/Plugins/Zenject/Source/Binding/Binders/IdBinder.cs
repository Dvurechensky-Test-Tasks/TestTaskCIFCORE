/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 января 2026 16:09:29
 * Version: 1.0.141
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


