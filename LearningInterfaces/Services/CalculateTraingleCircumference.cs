using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces.Services
{
    internal class CalculateTraingleCircumference : ICalculateCircumference
    {
        public double CalculateCircumference(double l)
        {
            return 3 * l;
        }
    }
}
