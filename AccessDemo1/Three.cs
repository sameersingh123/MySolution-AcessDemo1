using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    //Consuming members of Program class from the non-child class of same project
     class Three
    {
       static void Main()
        {
            Program p = new Program();
            //p.Test1(); // Error: 'Program.Test1()' is inaccessible due to its protection level
            p.Test2();
            //p.Test3(); // Error: 'Program.Test3()' is inaccessible due to its protection level
            p.Test4();
            p.Test5();
        }

    }
}
