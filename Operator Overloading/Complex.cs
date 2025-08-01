using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        //Operator Overloading 
        //+
        //Must Be : Public - Static

        public static Complex operator +(Complex left,Complex Right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 + Right?.Real ?? 0,
                Imag = left?.Imag ?? 0+ Right?.Imag??0,
            };
        }

        public static Complex operator -(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = (left?.Real??0) - (Right?.Real??0),
                Imag = (left?.Imag ??0) - (Right?.Imag??0),
            };
        }
        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
     
    }
}
