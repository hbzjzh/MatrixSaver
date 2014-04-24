using FerretLib.SFML;
using FerretLib.SFML.Utility;
using SFML.Graphics;
namespace FerretSS.Engines
{
    public class Epilepsy01 : IWorldEngine
    {
        private ViewPortCollection _viewports;
        byte r, g, b;

        public Epilepsy01()
        {            
        }

        #region IWorldEngine
        void IWorldEngine.Render()
        {
            foreach (var viewport in _viewports)
            {
                viewport.Window.Clear(new Color(r++, g += 2, b += 6));
                viewport.Window.Display();
            }
        }

        void IWorldEngine.Update()
        {
            
        }

        void IWorldEngine.Initialise(ViewPortCollection viewports)
        {
            _viewports = viewports;
        }
        #endregion
        
    }
}
