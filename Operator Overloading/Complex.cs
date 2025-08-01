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

        //Operator Overloading 
        //++ -- 
        //Function : Public - static 

        //Unary Operator -- ++ 
        public static Complex operator ++(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real++;
                return complex;
            }
            return new Complex();
        }

        public static Complex operator --(Complex complex)
        {
            if (complex is not null)
            {
                complex.Real--;
                return complex;
            }
            return new Complex();
        }

        //comparsion Operation Binary : > < >= <= != ==
        //Must Be Boolean 

        public static bool operator >(Complex left,Complex right )
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;

            return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;

            return left.Real < right.Real;
        }

        public static bool operator >=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag >= right.Imag;

            return left.Real >= right.Real;
        }

        public static bool operator <=(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag <= right.Imag;

            return left.Real <= right.Real;
        }

        public static bool operator ==(Complex left,Complex right)
        {
            return left.Real == right.Real && left.Imag == right.Imag;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.Real != right.Real || left.Imag != right.Imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }
     
    }
}
