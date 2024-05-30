using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces.Services
{
    internal class CalculateSquareCircumference : ICalculateCircumference
    {
        public double CalculateCircumference(double l)
        {
            return 4 * l;
        }
    }
}
