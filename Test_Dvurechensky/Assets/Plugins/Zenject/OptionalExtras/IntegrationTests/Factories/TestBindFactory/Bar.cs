/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 февраля 2026 07:40:37
 * Version: 1.0.168
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

