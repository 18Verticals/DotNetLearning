namespace Enum_keyword
{
    /// <summary>
    /// Enum keyword
    /// </summary>

    //An enum is a special "class" that represents a group of constants.

    enum Weekdays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday
    }

    enum Level
    {
        Low,
        Medium,
        High
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.Medium;

            Console.WriteLine(myLevel);

            Console.ReadLine();
        }
    }
}
