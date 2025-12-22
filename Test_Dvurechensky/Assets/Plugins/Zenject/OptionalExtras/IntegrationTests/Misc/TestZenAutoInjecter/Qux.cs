/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 декабря 2025 06:50:28
 * Version: 1.0.123
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

