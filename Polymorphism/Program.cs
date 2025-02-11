namespace Polymorphism
{
    /// <summary>
    /// Polymorphism is the ability of a variable,object, or function to take on MULTIPLE FORMS.
    /// Two type (1) compile type (method overloading) , (2) run time (method overriding)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Polymorphism obj = new Polymorphism();

            int i = obj.Add(10, 20);

            string str = obj.Add("Interview", "Happy");

            Console.WriteLine(i + " - " + str);

            DerivedClass objDerived = new DerivedClass();
            objDerived.Greetings();
        }
    }
    // overloading
    public class Polymorphism
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }
    }

    // overriding
    public class BaseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("BaseClass Hello!");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Greetings()
        {
            Console.WriteLine("DerivedClass Hello!");
        }
    }
}
