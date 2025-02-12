using static System.Runtime.InteropServices.JavaScript.JSType;

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

            Console.ReadLine();
        }
    }
    // overloading

    //Method overloading is a type of polymorphism in which we can create multiple methods of the same name in the
    //same class, and all methods work in different ways.
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

    //Method overriding is creating a method in the DERIVED class with the
    //SAME NAME and SIGNATURE as a method in the base class.

    //Overriding uses VIRTUAL keyword for base class method and OVERRIDE keyword for derived class method.

    //Overriding virtual method is optional.

    //Overriding is used to modify and provide a new implementation of the method inherited from a base class.
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
