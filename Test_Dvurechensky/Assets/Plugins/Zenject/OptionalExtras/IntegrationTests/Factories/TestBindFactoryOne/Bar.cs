/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 марта 2026 07:31:46
 * Version: 1.0.211
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

