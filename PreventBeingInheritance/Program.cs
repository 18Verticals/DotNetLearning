namespace PreventBeingInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public sealed class Employee //Using sealed keyword can not use Inheritance concept
    {
        public int Experience { get; set; }

        public void CalculateSalary()
        {
            int salary = Experience * 300000;

            Console.WriteLine("salary:{0} ", salary);
        }
    }

    //public class PermanentEmployee : Employee //not possible Inheritance cos of sealed keyword
    //{

    //}
}
