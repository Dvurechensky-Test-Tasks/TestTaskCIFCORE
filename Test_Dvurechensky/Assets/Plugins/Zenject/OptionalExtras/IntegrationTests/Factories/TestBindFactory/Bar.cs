/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 октября 2025 13:16:36
 * Version: 1.0.56
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

