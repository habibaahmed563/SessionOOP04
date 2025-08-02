using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Sealed
{
    internal class TypeA
    {
        public virtual int X { get; set; }
        public virtual void Myfun()
        {
            Console.WriteLine("My fun from TypeA");
        }
    }
}
