using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Abstraction
{
    internal class Rectangle : Shape //Implement And Inhert From Shape 
    {
        //Consert Class : Fully Implemented Class

        public override double GetArea()
        {
            return Dim01 *Dim02;
        }

        public override double Perimeter
        {
            get
            {
                return (Dim02 + Dim01) * 2;
            }
        }
    }
}
