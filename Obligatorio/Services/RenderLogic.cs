using Domain;
using Services.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RenderLogic
    {
        public Bitmap ShowImage(string ppmString)
        {
            try
            {
                var fileContents = ppmString.Split('\n');
                var resolution = fileContents[1].Split(' ');
                var width = int.Parse(resolution[0]);
                var height = int.Parse(resolution[1]);
                var bitmap = new Bitmap(width, height);
                for (int i = 3; i < fileContents.Length - 1; i++)
                {
                    var rgbValues = fileContents[i].Split(' ');
                    var r = int.Parse(rgbValues[0]);
                    var g = int.Parse(rgbValues[1]);
                    var b = int.Parse(rgbValues[2]);
                    var lineNumber = i - 3;
                    var pixelColumn = lineNumber % width;
                    var pixelRow = lineNumber / width;
                    bitmap.SetPixel(pixelColumn, pixelRow, Color.FromArgb(r, g, b));
                }
                return bitmap;
            }
            catch(Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void SetSceneRenderer(Renderer renderer, Scene scene)
        {
            try
            {
                string render = renderer.Render();
                scene.Render = render;
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public void SetScenePreview(Renderer renderer, Scene scene)
        {
            try
            {
                scene.Preview = renderer.Render();
            }
            catch (Exception e)
            {
                throw new ManagerException(e.Message);
            }
        }

        public Renderer CreateRenderer(RendererDTO dto)
        {
            Renderer renderer = new Renderer(dto.ResolutionX, dto.ResolutionY, dto.Up, dto.Scene);
            return renderer;
        }
    }
}
