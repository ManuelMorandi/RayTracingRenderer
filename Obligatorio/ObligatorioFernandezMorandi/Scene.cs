using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Scene
    {
        private const int FovMin = 1;
        private const int FovMax = 160;
        private const double ApertureMin = 0.1;
        private const double ApertureMax = 3;
        private const int NumberOfDecimals = 1;

        private User _owner;
        private string _name;
        private DateTime _creation;
        private List<UsedModel> _models;
        private DateTime _lastModification;
        private DateTime _lastRender;
        private Vector _lookFrom = new Vector (0, 2, 0);
        private Vector _lookAt = new Vector (0, 2, 5);
        private int _fov = 30;
        private string _render;
        private string _preview;
        private double _aperture = 0.5;
        private bool _blurred = false;

        public Scene()
        {
            _creation = DateTimeProvider.Now;
            _lastModification = DateTimeProvider.Now;
            _lastRender = DateTimeProvider.Now;
            _models = new List<UsedModel>();
            _render = "null";
            _preview = "null";
        }

        public User Owner { get => _owner; set => _owner = value; }

        public string Name
        {
            get => _name; 
            set
            {
                NameValidator validator = new NameValidator();
                validator.ValidateName(value);
                _name = value;
            }
        }

        public DateTime CreationDate { get => _creation; set => _creation = value; }

        public List<UsedModel> Models { get => _models; set => _models = value;}

        public DateTime LastModificationDate { get => _lastModification; set => _lastModification = value; }

        public DateTime LastRenderDate { get => _lastRender; set => _lastRender = value; }

        public Vector LookFrom { get => _lookFrom; set => _lookFrom = value; }

        public Vector LookAt { get => _lookAt; set => _lookAt = value; }

        public int Fov 
        { 
            get => _fov;
            set
            {
                ValidateFov(value);
                _fov = value;
            }
        }

        public string Render { get => _render; set => _render = value; }

        public string Preview { get => _preview; set => _preview = value; }

        public double Aperture 
        { 
            get => _aperture;
            set 
            {
                double aperture = Math.Round(value, NumberOfDecimals);
                ValidateAperture(aperture);
                _aperture = aperture;
            } 
        }

        public bool Blurred { get => _blurred; set => _blurred = value; }

        public void AddModel(UsedModel model)
        {
            _models.Add(model);
        }

        public void RemoveModel(UsedModel model)
        {
            _models.Remove(model);
        }

        public string GetDescription()
        {
            return "Última modificación: " + LastModificationDate;
        }

        private void ValidateFov(int fov)
        {
            if (IsFovOutsideLimits(fov))
                throw new BusinessLogicException("El campo de vision (FOV) debe ser un número entero entre 1 y 160");
        }

        private bool IsFovOutsideLimits(int fov)
        {
            return fov < FovMin || fov > FovMax;
        }

        private void ValidateAperture(double aperture)
        {
            if (IsApertureOutsideLimits(aperture))
                throw new BusinessLogicException("La apertura debe ser mayor a 0 y menor o igual a 3");
        }

        private bool IsApertureOutsideLimits(double aperture)
        {
            return aperture < ApertureMin || aperture > ApertureMax;
        }
    }
}
