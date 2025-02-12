namespace Test
{
    /// <summary>
    /// This is test program
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            // B b = new A(); // Not possible because child to parent accessing
           
            A a = new B();
            a.Abc(i); // O/P : Abc from A

            B b = new B();
            b.Abc(i); // O/P : Abc from B

            Console.ReadLine();
        }
    }
    class A
    {
        public void Abc(int q)
        {
            Console.WriteLine("Abc from A");
        }
    }

    class B : A
    {
        public void Abc(double p)
        {
            Console.WriteLine("Abc from B");
        }
    }
}
