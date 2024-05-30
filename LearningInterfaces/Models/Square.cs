using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces.Models
{
    internal class Square : BaseShape, IShape
    {
        public double Width { get; set; }
    }
}
