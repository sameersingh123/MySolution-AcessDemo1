using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    //Consuming members of Program class from the non-child class of different project
     class Five
    {
        static void Main()
        {
            AccessDemo1.Program p = new AccessDemo1.Program();
            //p.Test1(); // Error: 'Program.Test1()' is inaccessible due to its protection level
            p.Test2();
            //p.Test3(); // Error: 'Program.Test3()' is inaccessible due to its protection level
            //p.Test4(); // Error: 'Program.Test4()' is inaccessible due to its protection level
            //p.Test5(); // Error: 'Program.Test5()' is inaccessible due to its protection level
        }
    }
}
