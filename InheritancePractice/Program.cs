namespace InheritancePractice
{
    /// <summary>
    /// Inheritance is creating a PARENT-CHILD relationship between two classes, 
    /// where child class will automatically get the properties and methods of the parent.
    /// Inheritance is good for: REUSABILITY and ABSTRACTION of code
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Employee = new Employee()");
            
            Employee Employee = new Employee();
            Employee.Experience = 5;
            Employee.CalculateSalary();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("PermanentEmployee pEmployee = new PermanentEmployee()");

            PermanentEmployee pEmployee = new PermanentEmployee(); 
            pEmployee.Experience = 5;
            pEmployee.CalculateSalary();

            pEmployee.Name = "Kajal";
            pEmployee.EmpName();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("Employee upEmployee = pEmployee");

            Employee upEmployee = pEmployee; // Up casting
            upEmployee.Experience = 5;
            upEmployee.CalculateSalary(); // return parent class value cos not override
            
            upEmployee.CalculateSal(); // return child class value cos overridden 

            upEmployee.Name = "Heena";
            // upEmployee.EmpName(); // can not access base class method if sub class object assign to parent class

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("ContractEmployee cEmployee = new ContractEmployee()");

            ContractEmployee cEmployee = new ContractEmployee();
            cEmployee.Experience = 5;
            cEmployee.CalculateSalary();

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("ContractEmployee downcastedEmployee = downEmployee as ContractEmployee");

            Employee downEmployee = new ContractEmployee(); // Up casting
            //ContractEmployee downcastedEmployee = (ContractEmployee)downEmployee; // Down casting
            ContractEmployee downcastedEmployee = downEmployee as ContractEmployee ; // Down casting
            downcastedEmployee.Experience = 5;
            downcastedEmployee.CalculateSalary();
            downcastedEmployee.CalculateSal();
            downcastedEmployee.Name = "Sheela";
            downcastedEmployee.EmpName(); // can access base class method if parent object assign to sub class
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Experience { get; set; }
        public string Name { get; set; } = null!;

        //public abstract void EmpName();
        public void CalculateSalary()
        {
            int salary = Experience * 300000;

            Console.WriteLine("salary:{0} ", salary);
        }

        public virtual void CalculateSal()
        {
            int salary = Experience * 300000;

            Console.WriteLine("salary:{0} ", salary);
        }
    }

    public class PermanentEmployee : Employee
    {
        public void CalculateSalary()
        {
            int salary = Experience * 50000;

            Console.WriteLine("PermanentEmployee CalculateSalary:{0} ", salary);
        }

        public override void CalculateSal()
        {
            int salary = Experience * 50000;

            Console.WriteLine("Upcasting(override) CalculateSal:{0} ", salary);
        }

        public void EmpName()
        {
            string name = Name;

            Console.WriteLine("PermanentEmployee:{0} ", Name);
        }
    }

    public class ContractEmployee : Employee
    {
        public  void CalculateSalary()
        {
            int salary = Experience * 10000;

            Console.WriteLine("ContractEmployee salary:{0} ", salary);
        }

        public override void CalculateSal()
        {
            int salary = Experience * 100000;

            Console.WriteLine("downcasting(override) CalculateSal:{0} ", salary);
        }

        public void EmpName()
        {
            string name = Name;

            Console.WriteLine("ContractEmployee:{0} ", Name);
        }
    }
}
