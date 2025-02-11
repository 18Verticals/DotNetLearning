using System;

namespace Encapsulation
{
    /// <summary>
    /// Encapsulation means WRAPPING of data and methods into a single unit.
    /// </summary>
    internal class Program
    {
        public class Employee
        {
            //Make field private
            private int empExperience; //This field cannot be accessed from outside without the property

            public int EmpExperience // Property
            {
                get { return empExperience; }

                set { empExperience = value; }
            }

            //Shortcut Property
            //public int EmpExperience { get; set; }
        }

        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();

            objEmployee.EmpExperience = 3;
        }
    }
}
