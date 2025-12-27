/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 27 декабря 2025 15:50:16
 * Version: 1.0.128
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
