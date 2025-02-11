namespace TypeOfClass
{
    /// <summary>
    /// Explain class types 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public abstract class Class1{ } //Abstract classes cannot be instantiated directly. use inheritance
    public static class Class2{ } //Can not inherit , All members must be static, method can call using class name 
    public partial class Class3 { } //allow a class definition to be split across multiple files
    public sealed class Class4 { } //Can not inherit , Can be instantiated

    /* Difference between sealed & static
    is, you can create the object of
    sealed class, but you cannot create
    the object of static class. */
}
