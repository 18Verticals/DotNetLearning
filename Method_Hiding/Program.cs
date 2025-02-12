namespace Method_Hiding
{
    /// <summary>
    /// difference between Method Overriding and Method Hiding
    /// </summary>

    //In Method Hiding, you can hide the implementation of the methods of a base class from the derived class using the new keyword.
    //In other words, in overriding you are overriding the method but here in method hiding, you are completely redefining the method.

    //When to use method hiding?
    //If child class wants to implement some of the methods of the base class without disturbing base class.

    public class BaseClass
    {
        //hiding
        public void GreetingsBase()
        {
            Console.WriteLine("BaseClass Hello!");
        }

        //override
        public virtual void Greetings()
        {
            Console.WriteLine("BaseClass Hello!");
        }        
    }

    public class DerivedClass : BaseClass
    {
        // hiding
        public new void GreetingsBase()
        {
            Console.WriteLine("DerivedClass Hello!");
        }

        //override
        public override void Greetings()
        {
            Console.WriteLine("DerivedClass Hello!");
        }      
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objDerived = new DerivedClass();
            objDerived.Greetings(); //override
            objDerived.GreetingsBase(); // hiding 

            Console.ReadLine();
        }
    }
}
