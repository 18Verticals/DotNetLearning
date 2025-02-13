namespace IEnumerable
{
    //IEnumerable interface is used when
    //we want to ITERATE among collection classes using a FOREACH loop.
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>() {
                new Employee(){ Id = 1, Name="Bill" },
                new Employee(){ Id = 2, Name="Steve" }
            };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id + ", " + employee.Name);
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
