using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Model
    {
        private User _owner;
        private string _name;
        private Sphere _shape;
        private Material _material;
        private string _preview;

        public User Owner
        {
            get => _owner;
            set
            {
                ValidateOwner(value);
                _owner = value;
            }
        }

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

        public Sphere ModelShape
        {
            get => _shape;
            set
            {
                ValidateShape(value);
                _shape = value;
            }
        }

        public Material ModelMaterial
        {
            get => _material;
            set
            {
                ValidateMaterial(value);
                _material = value;
            }
        }

        public string Preview { get => _preview; set => _preview = value; }

        public string GetDescription()
        {
            return "Figura: " + ModelShape + ", Material: " + ModelMaterial;
        }

        public override string ToString()
        {
            return Name;
        }

        private void ValidateShape(Shape shape)
        {
            if (ShapeAndModelHaveDifferentOwners(shape))
                throw new BusinessLogicException("El dueño de la figura debe coincidir con el dueño del modelo");
        }

        private void ValidateMaterial(Material material)
        {
            if (MaterialAndModelHaveDifferentOwners(material))
                throw new BusinessLogicException("El dueño del material debe coincidir con el dueño del modelo");
        }

        private void ValidateOwner(User owner)
        {
            if (ModelAndMaterialHaveDifferentOwners(owner))
                throw new BusinessLogicException("El dueño del material debe coincidir con el dueño del modelo");
            if (ModelAndShapeHaveDifferentOwners(owner))
                throw new BusinessLogicException("El dueño de la figura debe coincidir con el dueño del modelo");
        }

        private bool ShapeAndModelHaveDifferentOwners(Shape shape)
        {
            return this.Owner != null && !shape.Owner.Equals(this.Owner);
        }
        private bool MaterialAndModelHaveDifferentOwners(Material material)
        {
            return this.Owner != null && !material.Owner.Equals(this.Owner);
        }

        private bool ModelAndShapeHaveDifferentOwners(User owner)
        {
            return this.ModelShape != null && !this.ModelShape.Owner.Equals(owner);
        }

        private bool ModelAndMaterialHaveDifferentOwners(User owner)
        {
            return this.ModelMaterial != null && !this.ModelMaterial.Owner.Equals(owner);
        }
    }
}
