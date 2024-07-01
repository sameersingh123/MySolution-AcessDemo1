using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
     class StaticAndNonStatic
    {
        int x;
        static int y = 20;
        const float PI = 3.14f;
        readonly int z;

        public StaticAndNonStatic(int x,int z)
        {
           this.x = x;
           this.z = z;
        }
        static void Main()
        {
            Console.WriteLine(y);
            Console.WriteLine(PI);
            StaticAndNonStatic s1 = new StaticAndNonStatic(10,50);
            StaticAndNonStatic s2 = new StaticAndNonStatic(30,60);

            s1.x= 100;
            s2.x = 200;
            Console.WriteLine("x value of s1: " + s1.x);
            Console.WriteLine("x value of s2: " + s2.x);
            Console.WriteLine("z value of s1: " + s1.z);
            Console.WriteLine("z value of s2: " + s2.z);
            

        }
    }
}
