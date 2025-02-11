namespace OopsConcepts
{
    /// <summary>
    /// cover object creation, Class and Encapsulation
    /// </summary>
    internal class Program // Class
    {
        static void Main(string[] args) // Main method 
        {
            Employee objEmployee = new Employee(); // object created of emp class

            objEmployee.Experience = 3; // Setting value of properties

            objEmployee.CalculateSalary(); // Calling Method 

            Console.ReadLine();
        }
    }

    public class Employee // Class
    {
        public Employee() // Default Constructor // if not written then by default create at time of object creation
        {
            //code
        }

        private int experience; // field // Encapsulation

        public int Experience // properties
        {
            get { return experience; } // get the value field

            set { experience = value; } // set the value field
        }

        //public int Experience { get; set; }

        public void CalculateSalary()
        {
            int salary = Experience * 300000;

            Console.WriteLine(salary);
        }
    }
}
