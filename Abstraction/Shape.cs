using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Abstraction
{
    //Abstract Class : partial class [Not Fully Implemented Clasa]
    //Concert Class :Fully Implemented Class 
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        //Abstract Method : Like Virtual Method Without Implementation 
        public abstract double GetArea();

        //Make this Method Abstract 

        //Abstract property : Like Virtual property Method Without Implementation
        public abstract double Perimeter { get; }

        public void Print ()
        {
            Console.WriteLine("Iam Shape");
        }

    }
}
