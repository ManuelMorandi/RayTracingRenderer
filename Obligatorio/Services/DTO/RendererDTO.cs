using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class RendererDTO
    {
        private int _resolutionX;
        private int _resolutionY;
        private Vector _up;
        private Scene _scene;

        public RendererDTO(int resolutionX, int resolutionY, Vector up, Scene scene)
        {
            _resolutionX = resolutionX;
            _resolutionY = resolutionY;
            _up = up;
            _scene = scene;
        }

        public int ResolutionX { get { return _resolutionX;} }
        public int ResolutionY { get { return _resolutionY;} }
        public Vector Up { get { return _up;} }
        public Scene Scene { get { return _scene;} }
    }
}
