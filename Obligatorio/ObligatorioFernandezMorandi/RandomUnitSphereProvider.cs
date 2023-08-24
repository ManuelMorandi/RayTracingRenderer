using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RandomUnitSphereProvider
    {
        private static RandomUnitSphereProvider _instance = null;

        public RandomUnitSphereProvider()
        {
            _instance = null;
        }

        public static RandomUnitSphereProvider GetInstance()
        {
            bool instanceIsEmpty = _instance == null;
            if (instanceIsEmpty)
                _instance = new RandomUnitSphereProvider();
            return _instance;
        }

        public Vector GetRandomInUnitSphere()
        {
            Vector vector;
            do
            {
                Vector vectorTemp = new Vector(RandomNumberProvider.RandomGenerator, RandomNumberProvider.RandomGenerator, RandomNumberProvider.RandomGenerator);
                vector = vectorTemp.Multiply(2).Subtract(new Vector(1, 1, 1));
            } while (vector.SquaredLength() >= 1);
            return vector;
        }
    }
}
