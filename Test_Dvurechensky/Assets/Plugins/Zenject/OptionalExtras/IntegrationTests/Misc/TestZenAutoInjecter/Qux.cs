/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 марта 2026 10:51:37
 * Version: 1.0.222
 */

using UnityEngine;

namespace Zenject.Tests.AutoInjecter
{
    public class Qux : MonoBehaviour
    {
        [Inject]
        public DiContainer Container;
    }
}

