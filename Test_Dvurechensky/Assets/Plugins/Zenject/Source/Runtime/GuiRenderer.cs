/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:12:51
 * Version: 1.0.37
 */

using UnityEngine;

namespace Zenject
{
    public class GuiRenderer : MonoBehaviour
    {
        GuiRenderableManager _renderableManager;

        [Inject]
        void Construct(GuiRenderableManager renderableManager)
        {
            _renderableManager = renderableManager;
        }

        public void OnGUI()
        {
            _renderableManager.OnGui();
        }
    }
}
