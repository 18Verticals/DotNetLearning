namespace Generics
{
    //Generics allows us to make classes and methods - type independent or type safe.
    internal class Program
    {
        static void Main(string[] args)
        {
            bool equal = Calculator<int>.AreEqual(4, 4);

            Console.WriteLine(equal);

            bool strEqual = Calculator<string>.AreEqual("Interview", "Happy");

            Console.WriteLine(strEqual);

            Console.ReadLine();
        }
    }

    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
