using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP04.Sealed
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        //public sealed override int A { get; set; }

        public sealed override void Myfun()
        {
            base.Myfun();
        }
    }
}
