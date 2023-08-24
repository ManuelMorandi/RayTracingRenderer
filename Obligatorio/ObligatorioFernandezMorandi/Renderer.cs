using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Renderer
    {
        private int _resolutionX;
        private int _resolutionY;
        private Scene _scene;
        private Vector _up;
        private RGBVector[][] _pixels;
        private ICamera _camera;

        public int ResolutionX { get => _resolutionX; set => _resolutionX = value; }

        public int ResolutionY { get => _resolutionY; set => _resolutionY = value; }

        public Scene Scene { get => _scene; set => _scene = value; }

        public Vector Up { get => _up; set => _up = value; }

        public Renderer(int resX, int resY, Vector upVector, Scene givenScene)
        {
            _resolutionX = resX;
            _resolutionY = resY;
            int aspectRatio = _resolutionX / _resolutionY;
            this._scene = givenScene;
            _up = upVector;
            _pixels = new RGBVector[_resolutionY][];
            for (int i = 0; i < _resolutionY; i++)
                _pixels[i] = new RGBVector[_resolutionX];
            bool blurred = _scene.Blurred;
            if (blurred)
            {
                double focalDistance = (_scene.LookFrom.Subtract(_scene.LookAt)).Length();
                _camera = new BlurredCamera(
                    this._scene.LookFrom,
                    this._scene.LookAt,
                    _up,
                    this._scene.Fov,
                    aspectRatio,
                    _scene.Aperture,
                    focalDistance);
            }
            else
            {
                _camera = new Camera(this._scene.LookFrom, this._scene.LookAt, _up, this._scene.Fov, aspectRatio);
            }   
        }
        
        public string Render()
        {
            const int samplesPerPixel = 50;
            const int maxDepth = 20;
            for (int row = _resolutionY - 1; row >= 0; row--)
            {
                for (int column = 0; column < _resolutionX; column++)
                {
                    RGBVector pixelColor = new RGBVector(0, 0, 0);
                    for (int sample = 0; sample < samplesPerPixel; sample++)
                    {
                        double u = (column + RandomNumberProvider.RandomGenerator) / _resolutionX;
                        double v = (row + RandomNumberProvider.RandomGenerator) / _resolutionY;
                        Ray ray = _camera.GetRay(u, v);
                        pixelColor.AddTo(ShootRay(ray, maxDepth));
                    }
                    pixelColor = pixelColor.DivideColor(samplesPerPixel);
                    SavePixel(row, column, pixelColor);
                }
            }

            string imageString = "P3\n" + _resolutionX + " " + _resolutionY + "\n255\n";
            for (int j = 0; j < _resolutionY; j++)
            {
                for (int i = 0; i < _resolutionX; i++)
                {
                    RGBVector color = _pixels[j][i];
                    double red = color.Red();
                    double green = color.Green();
                    double blue = color.Blue();
                    imageString += red + " " + green + " " + blue + "\n";
                }
            }
            return imageString;
        }

        private void SavePixel(int row, int column, RGBVector pixelRGB)
        {
            int posX = column;
            int posY = _resolutionY - row - 1;
            bool positionInBounds = posY < _resolutionY;
            if (positionInBounds)
            {
                _pixels[posY][posX] = pixelRGB;
            }
            else
            {
                throw new OverflowException("Pixel overflow error");
            }
        }

        private Vector ShootRay(Ray ray, int depth)
        {
            HitRecord hitRecord = null;
            double tMax = Math.Pow(10, 38);
            const double tMin = 0.001;
            Ray newRay = null;
            foreach (UsedModel model in this.Scene.Models)
            {
                HitRecord hit = model.IsModelHit(ray, tMin, tMax);
                if (ThereIsAHit(hit))
                {
                    hitRecord = hit;
                    tMax = hit.T;
                    newRay = model.SelectedModel.ModelMaterial.Scatter(ray, hitRecord);
                }
            }
            if (ThereIsAHit(hitRecord))
            {
                bool depthIsPositive = depth > 0;
                if (depthIsPositive)
                {
                    RandomUnitSphereProvider randomUnitSphere = new RandomUnitSphereProvider();
                    Vector newVectorPoint = hitRecord.Intersection.Add(hitRecord.Normal).Add(randomUnitSphere.GetRandomInUnitSphere());
                    Vector newVector = newVectorPoint.Subtract(hitRecord.Intersection);
                    bool rayIsEmpty = newRay == null;
                    if (rayIsEmpty) return new Vector(0, 0, 0);
                    Vector color = ShootRay(newRay, depth - 1);
                    RGBVector attenuation = hitRecord.Attenuation;
                    return new RGBVector(color.X * attenuation.X, color.Y * attenuation.Y, color.Z * attenuation.Z);
                }
                else
                {
                    return new RGBVector(0, 0, 0);
                }
            }
            else
            {
                Vector vectorDirectionUnit = ray.Direction.GetUnit();
                double posY = 0.5 * (vectorDirectionUnit.Y + 1);
                RGBVector colorStart = new RGBVector(1, 1, 1);
                RGBVector colorEnd = new RGBVector(0.5, 0.7, 1);
                return colorStart.Multiply(1 - posY).Add(colorEnd.Multiply(posY));
            }
        }

        private static bool ThereIsAHit(HitRecord hit)
        {
            return hit != null;
        }
    }
}
