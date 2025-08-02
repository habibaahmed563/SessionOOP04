using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Static
{
    internal class Utilities
    {
        public int X { get; set; }
        public int Y { get; set; }

        private static double pi ;

        //public Utilities()
        //{
        //    pi = 3.14;
        //}


        //static Method : class Member method
        public double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        //3.14
        //static property
        public static double PI
        {
            get
            {
                return pi;
            }
        }
    }
}
