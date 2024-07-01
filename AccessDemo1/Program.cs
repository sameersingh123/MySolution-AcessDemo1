namespace AccessDemo1
{
   

    //Consuming members of Program class from the same class of same project
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private method called.");
        }
        public void Test2()
        {
            Console.WriteLine("Public method called.");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected method called.");
        }
        internal void Test4()
        {
            Console.WriteLine("Internal method called.");
        }
        protected internal void Test5()
        {
            Console.WriteLine("Protected internal method called.");
        }

       
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();

        }
    }
}