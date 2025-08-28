/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 августа 2025 07:05:58
 * Version: 1.0.6
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

