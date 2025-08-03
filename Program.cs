using SessionOOP04.First_Project;
using SessionOOP04.Maths;

namespace SessionOOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //First Project 

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());


            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());


            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());


            Duration D4 = new Duration(3600);
            Console.WriteLine(D4.ToString());

            D3 = D1 + D2;
            Console.WriteLine(D3.ToString());

            D3 = D1 +D4;
            Console.WriteLine(D3.ToString());

            D3++;
            Console.WriteLine(D3.ToString());

            D3--;
            Console.WriteLine(D3.ToString());

            Console.WriteLine($"{D1 > D2}");


            //Seconnd Project 

            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"Add:{Maths.Maths.Add(num1, num2)}");
            Console.WriteLine($"Subtract:{Maths.Maths.Subtract(num1, num2)}");
            Console.WriteLine($"multiply:{Maths.Maths.multiply(num1, num2)}");
            Console.WriteLine($"Divide:{Maths.Maths.Divide(num1, num2)}");
            Console.WriteLine($"modulo:{Maths.Maths.modulo(num1, num2)}");


        }
    }
}
