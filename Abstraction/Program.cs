using Microsoft.VisualBasic;

namespace AbstractionUsingAbstractClass
{
    /// <summary>
    /// Abstraction means showing only required things and hide the BACKGROUND details.
    /// Can achive using abstact class and interface
    /// This example using Abstract class
    /// </summary>

    //Abstract class is a good choice when you are sure some methods are concrete/defined
    //and must be implemented in the SAME WAY in all derived classes.

    //Normally prefer Interface because it gives us the flexibility to modify the behavior at later stage.

    class Program // internal class access inside same Assembly(project) not another Assembly
    {
        static void Main(string[] args)
        {
            string name = "InterviewHappy";

            string firstname = name.Substring(0,9); // Substring is Background/hidden method

            Console.WriteLine(firstname);

            Vehicle myCar = new Car();
            myCar.Start();       // Output: Car starts with a key.
            myCar.DisplayType(); // Output: This is a Vehicle.

            Vehicle myBike = new Bike();
            myBike.Start();       // Output: Bike starts with a self-start button.

            Console.ReadLine();
        }
    }
    public abstract class Vehicle  // Abstract class
    {
        public abstract void Start(); // Abstract method (no body) , Background/hidden 

        public void DisplayType()  // Concrete method (has body)
        {
            Console.WriteLine("This is a Vehicle.");
        }
    }

    public class Car : Vehicle  // Inheriting abstract class
    {
        public override void Start()  // Implementing abstract method
        {
            Console.WriteLine("Car starts with a key.");
        }
    }

    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike starts with a self-start button.");
        }
    }
}
