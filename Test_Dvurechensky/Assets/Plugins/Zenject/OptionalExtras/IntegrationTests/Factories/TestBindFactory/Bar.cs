/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 ноября 2025 06:50:27
 * Version: 1.0.94
 */

using UnityEngine;

namespace Zenject.Tests.Factories.BindFactory
{
    //[CreateAssetMenu(fileName = "Bar", menuName = "Installers/Bar")]
    public class Bar : ScriptableObject
    {
        public class Factory : PlaceholderFactory<Bar>
        {
        }
    }
}

