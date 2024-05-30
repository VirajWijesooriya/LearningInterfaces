using LearningInterfaces.Models;
using LearningInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    internal class ShapeFactory
    {
        public ICalculateCircumference GetCalculateCircumference(BaseShape shape)
        {
            switch (shape)
            {
                case Square:
                    return new CalculateSquareCircumference();
                case Triangle:
                    return new CalculateTraingleCircumference();
                default:
                    throw new NotImplementedException();
            }
        }
    }

}
