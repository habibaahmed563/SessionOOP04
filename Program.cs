using SessionOOP04.Operator_Overloading;
using System.Drawing;

namespace SessionOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region abstraction
            //abstraction : 
            //abstract : C# kewword [class - methods - properties ]
            //abstract class
            //abstract method 
            //abstract property 

            //2D shape 

            //Shape shape = new Shape();
            //Note : Can't Create Object From Abstract Class

            //shape.GetArea();

            //Rectangle rectangle = new Rectangle() ;

            //rectangle.Perimeter = 12;

            //Console.WriteLine(rectangle.Perimeter);

            //Console.WriteLine(Rectangle.GetArea());

            //Rectangle.Print(); 
            #endregion

            #region Interface Vs Abstract Class
            // Interface Vs Abstract Class
            //.Net 3.1 Core  
            #endregion

            //Operator Overloading 

            //+ - * / % > < >= <= != == || && ! | & ^ >> 

            // + 

            //int X = 3 + 4;
            //string Y = "Hello"+"world";

            //Complex Number : Real + Imag

            // 4+3 i 
            // 4+3 ت

            Complex C01 = new Complex() { Real = 3, Imag = 4 };
            Complex C02 = new Complex() { Real = 4, Imag = 2 };

            Console.WriteLine(C01);
            Console.WriteLine(C02);

            Complex C03 = C01 - null;

            Console.WriteLine(C03);


        }
    }
}
