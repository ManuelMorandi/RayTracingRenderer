using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RandomNumberProvider
    {
        private static double? randomGenerator;
        private static Random random = new Random();
        public static double RandomGenerator
        {
            get
            {
                bool randomIsNotSet = randomGenerator == null;
                if (randomIsNotSet)
                {
                    return random.NextDouble();
                }
                else
                {
                    return (double)randomGenerator;
                }
            }
            set
            {
                randomGenerator = value;
            }
        }
    }
}
