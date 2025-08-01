using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Abstraction
{
    internal class Square : Shape
    {
        public override double Perimeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        public override double GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
