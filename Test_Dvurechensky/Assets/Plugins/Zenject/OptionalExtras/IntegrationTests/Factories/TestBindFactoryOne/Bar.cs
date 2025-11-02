/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 ноября 2025 17:21:45
 * Version: 1.0.73
 */

using UnityEngine;

namespace Zenject.Tests.Factories.BindFactoryOne
{
    //[CreateAssetMenu(fileName = "Bar", menuName = "Installers/Bar")]
    public class Bar : ScriptableObject
    {
        [Inject]
        public void Init(string value)
        {
            Value = value;
        }

        public string Value
        {
            get;
            private set;
        }

        public class Factory : PlaceholderFactory<string, Bar>
        {
        }
    }
}

