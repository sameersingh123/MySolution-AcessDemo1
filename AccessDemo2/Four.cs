namespace AccessDemo2
{
    //Consuming members of Program class from the child class of different project
    class Four: AccessDemo1.Program
    {
        static void Main(string[] args)
        {
           Four f = new Four();
            f.Test2();
            f.Test3();
            f.Test5();
        }

    }
}
