using SessionOOP04.Static;
using SessionOOP04.Mapping;
using SessionOOP04.Operator_Overloading;
using SessionOOP04.Static;
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

            #region Operator Overloading 
            //Operator Overloading 

            //+ - * / % > < >= <= != == || && ! | & ^ >> 

            // + 

            //int X = 3 + 4;
            //string Y = "Hello"+"world";

            //Complex Number : Real + Imag

            // 4+3 i 
            // 4+3 ت

            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() { Real = 4, Imag = 2 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03 = C01 - null;

            //Console.WriteLine(C03);

            // ++ --
            //Unary Operation 

            //int X = 12;

            //X++;
            //Console.WriteLine(X);

            //Console.WriteLine(C01);
            //Complex C03 = C01++;

            //Console.WriteLine(C03);

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is greater than C02 ");
            //}
            //else
            //{
            //    Console.WriteLine("C01 is  not greater than C02 ");
            //}
            #endregion

            #region User-Defined Casting Operator & Manual Mapping
            //double X = 12;

            //int Y =(int) X;
            //// ( int ): Cating Operator 

            Complex C01 = new Complex() { Real = 3, Imag = 4 };

            string S = (string)C01;
            //(string) : Convert Complex Number To String 

            //Operator Overloading
            //User-Defined Casting Operator 

            //int x = (int)C01;

            //Console.WriteLine(x);



            int x = (int)new Complex() { Real = 4, Imag = 7 };

            //Mapping : Convert from Datatype to Datatype

            //code first 
            //DB first 

            //User [id ,name ,Email ,password , username ,phonenumber ,cardnumber,exipredate]

            // UserViewModel
            // UserDto
            // [ name , email , phonenumber ]

            User user = new User(); //From DB 

            //Manual Mapping 
            UserDto userDto = new UserDto()
            {
                Email = user.Email,
                Name = user.Name,
                Phonenumber = user.Phonenumber
            };

            //Casting Operator 

            //Automapper : Mapping Automatic  
            #endregion

            #region static
            //Static : C# Keyword [class - method - property - constrictor - attributes]
            //static class
            //static method
            //static property 
            //static constructor 
            //static attribute

            Utilities U01 = new Utilities();
            Utilities U02 = new Utilities();
            Utilities U03 = new Utilities();

            //Console.WriteLine(U01.CmToInch(254));
            //Console.WriteLine(U02.CmToInch(254));
            //Console.WriteLine(U03.CmToInch(254));

            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));
            //Console.WriteLine(Utilities.CmToInch(254));


            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI);
            //Console.WriteLine(Utilities.PI); 
            #endregion



        }
    }
}
