using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
    public class UpdateSceneDTO
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime Render { get; set; }
        public Vector LookFrom { get; set; }
        public Vector LookAt { get; set; }
        public int Fov { get; set; }
        public string RenderImage { get; set; }
        public string PreviewImage { get; set; }
        public double Aperture { get; set; }
        public bool Blurred { get; set; }

        public UpdateSceneDTO(string name, string owner, DateTime render, Vector lookFrom, Vector lookAt, int fov, string renderImage, string previewImage, double aperture, bool blurred)
        {
            Name = name;
            Owner = owner;
            Render = render;
            LookFrom = lookFrom;
            LookAt = lookAt;
            Fov = fov;
            RenderImage = renderImage;
            PreviewImage = previewImage;
            Aperture = aperture;
            Blurred = blurred;
        }
    }
}
